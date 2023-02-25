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

            this.cbSort.SelectedIndex = 1;

            RefreshData();
        }

        public void RefreshData()
        {
            flpMain.Controls.Clear();
            var tovars = Repository.Instance.Tovars.Include(i => i.Category).Include(i => i.Postavshik)
                .Where(t => t.Name.Contains(tbSearch.Text)).ToList().Where(t => FilterCategory(t)).ToList();
            tovars = SortBy(tovars);
            foreach (var tovar in tovars)
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

        private List<Tovar> SortBy(List<Tovar> tovars)
        {
            if (checkBox1.Checked)
            {
                if (cbSort.SelectedIndex == -1)
                    return tovars.OrderBy(t => t.Id).ToList();
                else if (cbSort.SelectedItem.ToString() == "Название")
                    return tovars.OrderBy(t => t.Name).ToList();
                else if (cbSort.SelectedItem.ToString() == "Цена")
                    return tovars.OrderBy(t => t.Price).ToList();
            }
            else
            {
                if (cbSort.SelectedIndex == -1)
                    return tovars.OrderByDescending(t => t.Id).ToList();
                else if (cbSort.SelectedItem.ToString() == "Название")
                    return tovars.OrderByDescending(t => t.Name).ToList();
                else if (cbSort.SelectedItem.ToString() == "Цена")
                    return tovars.OrderByDescending(t => t.Price).ToList();
            }
            return tovars;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
