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

namespace FerreteríaPuntoVenta.View.order_purchase
{
    public partial class create_order_purchase : Form
    {
        public create_order_purchase()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
        private void create_order_purchase_Load(object sender, EventArgs e)
        {
            txtfecharegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtfecharegistro_TextChanged(object sender, EventArgs e)
        {



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
