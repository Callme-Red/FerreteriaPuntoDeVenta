using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FerreteríaPuntoVenta.Controller;

namespace FerreteríaPuntoVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customize_desing();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // your code

            hide_sub_menu();
        }

        private void button_buy_Click(object sender, EventArgs e)
        {
            show_sub_menu(panel_sub_menu_management_purchase);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void customize_desing()
        {
            panel_sub_menu_inventory.Visible = false;
            panel_sub_menu_management_purchase.Visible = false;
            panel_sub_menu_supplier.Visible = false;
        }

        private void hide_sub_menu()
        {
            if (panel_sub_menu_inventory.Visible == true)
                panel_sub_menu_inventory.Visible = false;

            if (panel_sub_menu_supplier.Visible == true)
                panel_sub_menu_supplier.Visible = false;
            if (panel_sub_menu_management_purchase.Visible == true)
                panel_sub_menu_management_purchase.Visible = false;
        }

        private void show_sub_menu (Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hide_sub_menu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
                
        }
     
     
        private void button_purchase_Click(object sender, EventArgs e)
        {

        }

        private void button_inventario_Click(object sender, EventArgs e)
        {
         
                button_inventario.BackColor = Color.FromArgb(37, 36, 81);
                
                show_sub_menu(panel_sub_menu_inventory);
            }
            
        

        private void botton_product_Click(object sender, EventArgs e)
        {
            // your code
            
            hide_sub_menu();
        }

        private void botton_inventory_Click(object sender, EventArgs e)
        {
            // your code

            hide_sub_menu();
        }

        private void panel_sub_menu_management_purchase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_management_supplier_Click(object sender, EventArgs e)
        {
            show_sub_menu(panel_sub_menu_supplier);
        }

        private void panel_form_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form active_form = null;
        private void open_panel_form(Form panel_form)
        {
            if (active_form != null)
                active_form.Close();
            active_form = panel_form;
            panel_form.TopLevel = false;
            panel_form.FormBorderStyle = FormBorderStyle.None;
            panel_form.Dock = DockStyle.Fill;
          
        }

        private void botton_inicio_Click(object sender, EventArgs e)
        {
            hide_sub_menu();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button_cerrar_MouseEnter(object sender, EventArgs e)
        {
            button_cerrar.BackColor = Color.DarkGray;
        }

        private void button_cerrar_MouseLeave(object sender, EventArgs e)
        {
            button_cerrar.BackColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MasterController mc = new MasterController();
            mc.listPais();
        }
    }
}
