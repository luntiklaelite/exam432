using GlazAlmaz.Forms;
using GlazAlmaz.Models;
using GlazAlmaz.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazAlmaz.Controls
{
    public partial class TovarViewControl : UserControl
    {
        public event Action RefreshData;
        private Tovar tovar = null;
        public TovarViewControl(Tovar tovar)
        {
            InitializeComponent();
            tbName.Text = tovar.Name;
            tbPrice.Text = tovar.Price.ToString();
            var path = $"images/{tovar.PictureFileName}";

            if (!string.IsNullOrEmpty(tovar.PictureFileName) && File.Exists(path))
            {
                pbTovar.Image = new Bitmap(path);
            }

            if(Repository.LocalUser.Role.Id != 2)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }

            this.tovar = tovar;
        }

        public TovarViewControl() { }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Repository.Instance.Tovars.Remove(tovar);
            Repository.Instance.SaveChanges();
            RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new TovarCommandForm(tovar).ShowDialog();
            RefreshData();
        }
    }
}
