using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteríaPuntoVenta.View.menus
{
    public partial class menus : Form
    {
        public menus()
        {
            InitializeComponent();
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

        private void show_sub_menu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hide_sub_menu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void menus_Load(object sender, EventArgs e)
        {

        }

        private void button_inventario_Click(object sender, EventArgs e)
        {
            button_inventario.BackColor = Color.FromArgb(37, 36, 81);
                
                show_sub_menu(panel_sub_menu_inventory);
        }

        private void botton_movimiento_Click(object sender, EventArgs e)
        {
            hide_sub_menu();
        }

        private void botton_product_Click(object sender, EventArgs e)
        {
            hide_sub_menu();
        }

        private void botton_inventory_Click(object sender, EventArgs e)
        {
            hide_sub_menu();
        }

        private void button_request_purchase_Click(object sender, EventArgs e)
        {
            hide_sub_menu();
        }

        private void button_order_purchase_Click(object sender, EventArgs e)
        {
            hide_sub_menu();
        }

        private void button_purchase_Click(object sender, EventArgs e)
        {
            hide_sub_menu();
        }

        private void button_management_purchase_Click(object sender, EventArgs e)
        {
            show_sub_menu(panel_sub_menu_management_purchase);
        }

        private void button_management_supplier_Click(object sender, EventArgs e)
        {
            show_sub_menu(panel_sub_menu_supplier);
        }

        private void button_contact_supplier_Click(object sender, EventArgs e)
        {
            hide_sub_menu();
        }

        private void button_supplier_Click(object sender, EventArgs e)
        {
            hide_sub_menu();
        }
    }
}
