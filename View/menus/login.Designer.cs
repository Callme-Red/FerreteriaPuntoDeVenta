
namespace FerreteríaPuntoVenta.View.login
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textClave = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_minim = new System.Windows.Forms.PictureBox();
            this.button_cerrar = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_minim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 330);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(285, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 1);
            this.panel3.TabIndex = 2;
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.ForeColor = System.Drawing.Color.White;
            this.textUser.Location = new System.Drawing.Point(285, 71);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(400, 13);
            this.textUser.TabIndex = 2;
            this.textUser.Text = "USUARIO";
            this.textUser.Enter += new System.EventHandler(this.textUser_Enter);
            this.textUser.Leave += new System.EventHandler(this.textUser_Leave);
            // 
            // textClave
            // 
            this.textClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.textClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textClave.ForeColor = System.Drawing.Color.White;
            this.textClave.Location = new System.Drawing.Point(290, 139);
            this.textClave.Name = "textClave";
            this.textClave.Size = new System.Drawing.Size(400, 13);
            this.textClave.TabIndex = 3;
            this.textClave.Text = "CLAVE";
            this.textClave.Enter += new System.EventHandler(this.textClave_Enter);
            this.textClave.Leave += new System.EventHandler(this.textClave_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(290, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 1);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(394, 1);
            this.panel5.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(285, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(399, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "ACCEDER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_minim
            // 
            this.button_minim.Image = ((System.Drawing.Image)(resources.GetObject("button_minim.Image")));
            this.button_minim.Location = new System.Drawing.Point(659, 0);
            this.button_minim.Name = "button_minim";
            this.button_minim.Size = new System.Drawing.Size(30, 25);
            this.button_minim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.button_minim.TabIndex = 5;
            this.button_minim.TabStop = false;
            this.button_minim.Click += new System.EventHandler(this.button_minim_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("button_cerrar.Image")));
            this.button_cerrar.Location = new System.Drawing.Point(695, 0);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(30, 25);
            this.button_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.button_cerrar.TabIndex = 6;
            this.button_cerrar.TabStop = false;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(720, 330);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.button_minim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.Enter += new System.EventHandler(this.login_Enter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_minim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox button_minim;
        private System.Windows.Forms.PictureBox button_cerrar;
    }
}