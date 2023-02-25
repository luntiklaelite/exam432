using GlazAlmaz.Controls;
using GlazAlmaz.Models;
using GlazAlmaz.Models.Domain;
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
    public partial class TovarsForm : Form
    {
        public TovarsForm()
        {
            InitializeComponent();
            if (Repository.LocalUser.Role.Id != 2)
            {
                btnAdd.Enabled = false;
            }

            this.cbCategory.Items.Add("Все");
            this.cbCategory.Items.AddRange(Repository.Instance.Categories.ToArray());

            RefreshData();
        }

        public void RefreshData()
        {
            flpMain.Controls.Clear();
            foreach(var tovar in Repository.Instance.Tovars.Include(i => i.Category).Include(i => i.Postavshik)
                .Where(t => t.Name.Contains(tbSearch.Text)).ToList().Where(t => FilterCategory(t)))
            {
                var control = new TovarViewControl(tovar);
                control.Width = flpMain.Width - 20;
                control.RefreshData += RefreshData;
                flpMain.Controls.Add(control);
            }
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new TovarCommandForm(null).ShowDialog();
            RefreshData();
        }

        private bool FilterCategory(Tovar t)
        {
            if(cbCategory.SelectedIndex == -1 || cbCategory.SelectedIndex == 0)
            {
                return true;
            }
            Category category = (cbCategory.SelectedItem as Category);
            if(category != null)
            {
                return t.Category.Id == category.Id;
            }
            return false;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
