
namespace FerreteríaPuntoVenta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel_sub_menu_management_purchase = new System.Windows.Forms.Panel();
            this.button_purchase = new System.Windows.Forms.Button();
            this.button_order_purchase = new System.Windows.Forms.Button();
            this.button_request_purchase = new System.Windows.Forms.Button();
            this.panel_sub_menu_supplier = new System.Windows.Forms.Panel();
            this.button_supplier = new System.Windows.Forms.Button();
            this.button_contact_supplier = new System.Windows.Forms.Button();
            this.button_management_supplier = new System.Windows.Forms.Button();
            this.button_management_purchase = new System.Windows.Forms.Button();
            this.panel_sub_menu_inventory = new System.Windows.Forms.Panel();
            this.botton_inventory = new System.Windows.Forms.Button();
            this.botton_product = new System.Windows.Forms.Button();
            this.botton_movimiento = new System.Windows.Forms.Button();
            this.button_inventario = new System.Windows.Forms.Button();
            this.botton_inicio = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_minim = new System.Windows.Forms.PictureBox();
            this.button_cerrar = new System.Windows.Forms.PictureBox();
            this.panel_form = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel_sub_menu_management_purchase.SuspendLayout();
            this.panel_sub_menu_supplier.SuspendLayout();
            this.panel_sub_menu_inventory.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_minim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_cerrar)).BeginInit();
            this.panel_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.panel_sub_menu_management_purchase);
            this.panelMenu.Controls.Add(this.button_management_purchase);
            this.panelMenu.Controls.Add(this.panel_sub_menu_inventory);
            this.panelMenu.Controls.Add(this.button_inventario);
            this.panelMenu.Controls.Add(this.botton_inicio);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 720);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // panel_sub_menu_management_purchase
            // 
            this.panel_sub_menu_management_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_sub_menu_management_purchase.Controls.Add(this.button_purchase);
            this.panel_sub_menu_management_purchase.Controls.Add(this.button_order_purchase);
            this.panel_sub_menu_management_purchase.Controls.Add(this.button_request_purchase);
            this.panel_sub_menu_management_purchase.Controls.Add(this.panel_sub_menu_supplier);
            this.panel_sub_menu_management_purchase.Controls.Add(this.button_management_supplier);
            this.panel_sub_menu_management_purchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_sub_menu_management_purchase.Location = new System.Drawing.Point(0, 237);
            this.panel_sub_menu_management_purchase.Name = "panel_sub_menu_management_purchase";
            this.panel_sub_menu_management_purchase.Size = new System.Drawing.Size(250, 192);
            this.panel_sub_menu_management_purchase.TabIndex = 6;
            this.panel_sub_menu_management_purchase.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_sub_menu_management_purchase_Paint);
            // 
            // button_purchase
            // 
            this.button_purchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_purchase.FlatAppearance.BorderSize = 0;
            this.button_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_purchase.ForeColor = System.Drawing.Color.LightGray;
            this.button_purchase.Location = new System.Drawing.Point(0, 138);
            this.button_purchase.Name = "button_purchase";
            this.button_purchase.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button_purchase.Size = new System.Drawing.Size(250, 24);
            this.button_purchase.TabIndex = 4;
            this.button_purchase.Text = "Compra";
            this.button_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_purchase.UseVisualStyleBackColor = true;
            this.button_purchase.Click += new System.EventHandler(this.button_purchase_Click);
            // 
            // button_order_purchase
            // 
            this.button_order_purchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_order_purchase.FlatAppearance.BorderSize = 0;
            this.button_order_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_order_purchase.ForeColor = System.Drawing.Color.LightGray;
            this.button_order_purchase.Location = new System.Drawing.Point(0, 115);
            this.button_order_purchase.Name = "button_order_purchase";
            this.button_order_purchase.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button_order_purchase.Size = new System.Drawing.Size(250, 23);
            this.button_order_purchase.TabIndex = 3;
            this.button_order_purchase.Text = "Orden de compra";
            this.button_order_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_order_purchase.UseVisualStyleBackColor = true;
            // 
            // button_request_purchase
            // 
            this.button_request_purchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_request_purchase.FlatAppearance.BorderSize = 0;
            this.button_request_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_request_purchase.ForeColor = System.Drawing.Color.LightGray;
            this.button_request_purchase.Location = new System.Drawing.Point(0, 92);
            this.button_request_purchase.Name = "button_request_purchase";
            this.button_request_purchase.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button_request_purchase.Size = new System.Drawing.Size(250, 23);
            this.button_request_purchase.TabIndex = 2;
            this.button_request_purchase.Text = "Pedido de compra";
            this.button_request_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_request_purchase.UseVisualStyleBackColor = true;
            // 
            // panel_sub_menu_supplier
            // 
            this.panel_sub_menu_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_sub_menu_supplier.Controls.Add(this.button_supplier);
            this.panel_sub_menu_supplier.Controls.Add(this.button_contact_supplier);
            this.panel_sub_menu_supplier.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_sub_menu_supplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_sub_menu_supplier.Location = new System.Drawing.Point(0, 23);
            this.panel_sub_menu_supplier.Name = "panel_sub_menu_supplier";
            this.panel_sub_menu_supplier.Size = new System.Drawing.Size(250, 69);
            this.panel_sub_menu_supplier.TabIndex = 1;
            // 
            // button_supplier
            // 
            this.button_supplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_supplier.FlatAppearance.BorderSize = 0;
            this.button_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_supplier.ForeColor = System.Drawing.Color.Silver;
            this.button_supplier.Location = new System.Drawing.Point(0, 23);
            this.button_supplier.Name = "button_supplier";
            this.button_supplier.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button_supplier.Size = new System.Drawing.Size(250, 23);
            this.button_supplier.TabIndex = 2;
            this.button_supplier.Text = "Proveedor";
            this.button_supplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_supplier.UseVisualStyleBackColor = true;
            // 
            // button_contact_supplier
            // 
            this.button_contact_supplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_contact_supplier.FlatAppearance.BorderSize = 0;
            this.button_contact_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contact_supplier.ForeColor = System.Drawing.Color.Silver;
            this.button_contact_supplier.Location = new System.Drawing.Point(0, 0);
            this.button_contact_supplier.Name = "button_contact_supplier";
            this.button_contact_supplier.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button_contact_supplier.Size = new System.Drawing.Size(250, 23);
            this.button_contact_supplier.TabIndex = 1;
            this.button_contact_supplier.Text = "Contacto de proveedor";
            this.button_contact_supplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_contact_supplier.UseVisualStyleBackColor = true;
            // 
            // button_management_supplier
            // 
            this.button_management_supplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_management_supplier.FlatAppearance.BorderSize = 0;
            this.button_management_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_management_supplier.ForeColor = System.Drawing.Color.LightGray;
            this.button_management_supplier.Location = new System.Drawing.Point(0, 0);
            this.button_management_supplier.Name = "button_management_supplier";
            this.button_management_supplier.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button_management_supplier.Size = new System.Drawing.Size(250, 23);
            this.button_management_supplier.TabIndex = 0;
            this.button_management_supplier.Text = "Proveedor";
            this.button_management_supplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_management_supplier.UseVisualStyleBackColor = true;
            this.button_management_supplier.Click += new System.EventHandler(this.button_management_supplier_Click);
            // 
            // button_management_purchase
            // 
            this.button_management_purchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_management_purchase.FlatAppearance.BorderSize = 0;
            this.button_management_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_management_purchase.ForeColor = System.Drawing.Color.White;
            this.button_management_purchase.Location = new System.Drawing.Point(0, 214);
            this.button_management_purchase.Name = "button_management_purchase";
            this.button_management_purchase.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_management_purchase.Size = new System.Drawing.Size(250, 23);
            this.button_management_purchase.TabIndex = 5;
            this.button_management_purchase.Text = "Gestion de compra";
            this.button_management_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_management_purchase.UseVisualStyleBackColor = true;
            this.button_management_purchase.Click += new System.EventHandler(this.button_buy_Click);
            // 
            // panel_sub_menu_inventory
            // 
            this.panel_sub_menu_inventory.AutoScroll = true;
            this.panel_sub_menu_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_sub_menu_inventory.Controls.Add(this.botton_inventory);
            this.panel_sub_menu_inventory.Controls.Add(this.botton_product);
            this.panel_sub_menu_inventory.Controls.Add(this.botton_movimiento);
            this.panel_sub_menu_inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_sub_menu_inventory.Location = new System.Drawing.Point(0, 123);
            this.panel_sub_menu_inventory.Name = "panel_sub_menu_inventory";
            this.panel_sub_menu_inventory.Size = new System.Drawing.Size(250, 91);
            this.panel_sub_menu_inventory.TabIndex = 4;
            // 
            // botton_inventory
            // 
            this.botton_inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.botton_inventory.FlatAppearance.BorderSize = 0;
            this.botton_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botton_inventory.ForeColor = System.Drawing.Color.LightGray;
            this.botton_inventory.Location = new System.Drawing.Point(0, 46);
            this.botton_inventory.Name = "botton_inventory";
            this.botton_inventory.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.botton_inventory.Size = new System.Drawing.Size(250, 28);
            this.botton_inventory.TabIndex = 2;
            this.botton_inventory.Text = "Inventario";
            this.botton_inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botton_inventory.UseVisualStyleBackColor = true;
            this.botton_inventory.Click += new System.EventHandler(this.botton_inventory_Click);
            // 
            // botton_product
            // 
            this.botton_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.botton_product.FlatAppearance.BorderSize = 0;
            this.botton_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botton_product.ForeColor = System.Drawing.Color.LightGray;
            this.botton_product.Location = new System.Drawing.Point(0, 23);
            this.botton_product.Name = "botton_product";
            this.botton_product.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.botton_product.Size = new System.Drawing.Size(250, 23);
            this.botton_product.TabIndex = 1;
            this.botton_product.Text = "Producto";
            this.botton_product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botton_product.UseVisualStyleBackColor = true;
            this.botton_product.Click += new System.EventHandler(this.botton_product_Click);
            // 
            // botton_movimiento
            // 
            this.botton_movimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.botton_movimiento.FlatAppearance.BorderSize = 0;
            this.botton_movimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botton_movimiento.ForeColor = System.Drawing.Color.LightGray;
            this.botton_movimiento.Location = new System.Drawing.Point(0, 0);
            this.botton_movimiento.Name = "botton_movimiento";
            this.botton_movimiento.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.botton_movimiento.Size = new System.Drawing.Size(250, 23);
            this.botton_movimiento.TabIndex = 0;
            this.botton_movimiento.Text = "Movimiento";
            this.botton_movimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botton_movimiento.UseVisualStyleBackColor = true;
            this.botton_movimiento.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_inventario
            // 
            this.button_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_inventario.FlatAppearance.BorderSize = 0;
            this.button_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_inventario.ForeColor = System.Drawing.Color.White;
            this.button_inventario.Location = new System.Drawing.Point(0, 100);
            this.button_inventario.Name = "button_inventario";
            this.button_inventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_inventario.Size = new System.Drawing.Size(250, 23);
            this.button_inventario.TabIndex = 3;
            this.button_inventario.Text = "Gestion de inventario";
            this.button_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_inventario.UseVisualStyleBackColor = true;
            this.button_inventario.Click += new System.EventHandler(this.button_inventario_Click);
            // 
            // botton_inicio
            // 
            this.botton_inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.botton_inicio.FlatAppearance.BorderSize = 0;
            this.botton_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botton_inicio.ForeColor = System.Drawing.Color.White;
            this.botton_inicio.Location = new System.Drawing.Point(0, 75);
            this.botton_inicio.Name = "botton_inicio";
            this.botton_inicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.botton_inicio.Size = new System.Drawing.Size(250, 25);
            this.botton_inicio.TabIndex = 2;
            this.botton_inicio.Text = "Inicio";
            this.botton_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botton_inicio.UseVisualStyleBackColor = true;
            this.botton_inicio.Click += new System.EventHandler(this.botton_inicio_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 75);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.button_minim);
            this.panel1.Controls.Add(this.button_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 75);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button_minim
            // 
            this.button_minim.Image = ((System.Drawing.Image)(resources.GetObject("button_minim.Image")));
            this.button_minim.Location = new System.Drawing.Point(640, 0);
            this.button_minim.Name = "button_minim";
            this.button_minim.Size = new System.Drawing.Size(30, 25);
            this.button_minim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.button_minim.TabIndex = 4;
            this.button_minim.TabStop = false;
            this.button_minim.Click += new System.EventHandler(this.button_minim_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("button_cerrar.Image")));
            this.button_cerrar.Location = new System.Drawing.Point(670, 0);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(30, 25);
            this.button_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.button_cerrar.TabIndex = 3;
            this.button_cerrar.TabStop = false;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            this.button_cerrar.MouseEnter += new System.EventHandler(this.button_cerrar_MouseEnter);
            this.button_cerrar.MouseLeave += new System.EventHandler(this.button_cerrar_MouseLeave);
            // 
            // panel_form
            // 
            this.panel_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.panel_form.Controls.Add(this.button1);
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Location = new System.Drawing.Point(250, 75);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(700, 645);
            this.panel_form.TabIndex = 2;
            this.panel_form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_form_Paint);
            this.panel_form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_form_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listar paises";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(950, 720);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 720);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel_sub_menu_management_purchase.ResumeLayout(false);
            this.panel_sub_menu_supplier.ResumeLayout(false);
            this.panel_sub_menu_inventory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_minim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_cerrar)).EndInit();
            this.panel_form.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button botton_inicio;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel_sub_menu_inventory;
        private System.Windows.Forms.Button botton_movimiento;
        private System.Windows.Forms.Button button_inventario;
        private System.Windows.Forms.Button botton_inventory;
        private System.Windows.Forms.Button botton_product;
        private System.Windows.Forms.Button button_management_purchase;
        private System.Windows.Forms.Panel panel_sub_menu_management_purchase;
        private System.Windows.Forms.Button button_management_supplier;
        private System.Windows.Forms.Button button_request_purchase;
        private System.Windows.Forms.Panel panel_sub_menu_supplier;
        private System.Windows.Forms.Button button_supplier;
        private System.Windows.Forms.Button button_contact_supplier;
        private System.Windows.Forms.Button button_purchase;
        private System.Windows.Forms.Button button_order_purchase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.PictureBox button_cerrar;
        private System.Windows.Forms.PictureBox button_minim;
        private System.Windows.Forms.Button button1;
    }
}

