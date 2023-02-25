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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            RefreshData();
        }

        public void RefreshData()
        {
            foreach(var user in Repository.Instance.Users.Include(i => i.Role).Where(u => u.Login.Contains(tbSearch.Text)))
            {
                int i = dgvMain.Rows.Add(user.Login, user.Password, user.Role.Name);
                dgvMain.Rows[i].Tag = user;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
