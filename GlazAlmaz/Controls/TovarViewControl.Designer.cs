
namespace GlazAlmaz.Controls
{
    partial class TovarViewControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbTovar = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTovar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTovar
            // 
            this.pbTovar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTovar.Image = global::GlazAlmaz.Properties.Resources.picture;
            this.pbTovar.Location = new System.Drawing.Point(14, 12);
            this.pbTovar.Name = "pbTovar";
            this.pbTovar.Size = new System.Drawing.Size(343, 136);
            this.pbTovar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTovar.TabIndex = 0;
            this.pbTovar.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.AutoSize = true;
            this.tbName.Location = new System.Drawing.Point(14, 161);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(93, 15);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "Наименование:";
            // 
            // tbPrice
            // 
            this.tbPrice.AutoSize = true;
            this.tbPrice.Location = new System.Drawing.Point(14, 176);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(38, 15);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.Text = "Цена:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(14, 194);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(197, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TovarViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(102)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pbTovar);
            this.MinimumSize = new System.Drawing.Size(369, 226);
            this.Name = "TovarViewControl";
            this.Size = new System.Drawing.Size(369, 226);
            ((System.ComponentModel.ISupportInitialize)(this.pbTovar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTovar;
        private System.Windows.Forms.Label tbName;
        private System.Windows.Forms.Label tbPrice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
