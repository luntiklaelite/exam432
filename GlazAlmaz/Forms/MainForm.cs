using GlazAlmaz.Models;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblHello.Text = $"{Repository.LocalUser.Role.Name} - {Repository.LocalUser.Login}";
            if(Repository.LocalUser.Role.Id == 1)
            {
                btnUsers.Enabled = false;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTovars_Click(object sender, EventArgs e)
        {
            new TovarsForm().Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new UserForm().Show();
        }
    }
}
