using GlazAlmaz.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazAlmaz.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            var user = Repository.Instance.Users.Include(i => i.Role)
                .FirstOrDefault(u => u.Login == tbLogin.Text && u.Password == tbPass.Text);

            if(user != null)
            {
                Hide();
                Repository.LocalUser = user;
                new MainForm().ShowDialog();
                Repository.LocalUser = null;
                Show();
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
                return;
            }
        }
    }
}