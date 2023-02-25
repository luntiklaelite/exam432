
namespace GlazAlmaz.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnOut = new System.Windows.Forms.Button();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTovars = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.btnOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOut.Location = new System.Drawing.Point(12, 124);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(143, 23);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Выйти";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(102)))), ((int)(((byte)(128)))));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsers.Location = new System.Drawing.Point(12, 45);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(284, 32);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Пользователи";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnTovars
            // 
            this.btnTovars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(102)))), ((int)(((byte)(128)))));
            this.btnTovars.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTovars.Location = new System.Drawing.Point(12, 83);
            this.btnTovars.Name = "btnTovars";
            this.btnTovars.Size = new System.Drawing.Size(284, 31);
            this.btnTovars.TabIndex = 5;
            this.btnTovars.Text = "Товары";
            this.btnTovars.UseVisualStyleBackColor = false;
            this.btnTovars.Click += new System.EventHandler(this.btnTovars_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(12, 9);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(82, 15);
            this.lblHello.TabIndex = 6;
            this.lblHello.Text = "Логин + роль";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(209)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(308, 159);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnTovars);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOut;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnTovars;
        private System.Windows.Forms.Label lblHello;
    }
}