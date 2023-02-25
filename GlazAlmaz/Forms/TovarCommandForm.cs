using GlazAlmaz.Models;
using GlazAlmaz.Models.Domain;
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
    public partial class TovarCommandForm : Form
    {
        private Tovar tovar;
        public TovarCommandForm(Tovar tovar)
        {
            InitializeComponent();
            this.cbCategory.Items.AddRange(Repository.Instance.Categories.ToArray());
            this.cbPostavshik.Items.AddRange(Repository.Instance.Postavshiks.ToArray());

            this.tovar = tovar;
            this.tbDescription.Text = tovar?.Description;
            this.tbName.Text = tovar?.Name;
            this.tbPrice.Text = tovar?.Price.ToString();
            this.tbImagePath.Text = tovar?.PictureFileName;
            this.cbCategory.SelectedItem = tovar?.Category;
            this.cbPostavshik.SelectedItem = tovar?.Postavshik;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!decimal.TryParse(tbPrice.Text, out decimal price))
            {
                MessageBox.Show("Неправильный формат цены");
                return;
            }

            if(cbCategory.SelectedIndex == -1 || cbPostavshik.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            bool needAdd = tovar == null;

            if(tovar == null)
            {
                tovar = new Tovar();
            }

            tovar.Name = this.tbName.Text;
            tovar.Description = this.tbDescription.Text;
            tovar.Price = price;
            tovar.PictureFileName = this.tbImagePath.Text;
            tovar.Category = this.cbCategory.SelectedItem as Category;
            tovar.Postavshik = this.cbPostavshik.SelectedItem as Postavshik;

            if(needAdd)
            {
                Repository.Instance.Tovars.Add(tovar);
            }

            Repository.Instance.SaveChanges();
            Close();
        }
    }
}
