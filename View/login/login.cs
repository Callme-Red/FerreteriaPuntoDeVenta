using FerreteríaPuntoVenta.ConnectionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteríaPuntoVenta.View.login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        

        public void logeo()
        {
            

            try
            {
                String cnn = ConnectionDB.MasterConnection.s_connectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("select usuario_nombre,usuario_clave,usuario_token,usuario_estado_id from [dbo].[cat_usuario] where usuario_nombre='"+textUser.Text+ "'  and usuario_clave='" +textClave.Text+ "'  and usuario_token = 1 and usuario_estado_id=2", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            
                            MessageBox.Show("Login existo bienvenido");

                        } else
                        {
                            MessageBox.Show("Login incorrecto");
                        }
                    }

                }
            }
            catch (Exception ho)
            {
                MessageBox.Show(ho.ToString());
            }
          
        }
        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "USUARIO")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.LightGray;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "USUARIO";
                textUser.ForeColor = Color.White;
            }
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_Enter(object sender, EventArgs e)
        {
        }

        private void textClave_Enter(object sender, EventArgs e)
        {
            if (textClave.Text == "CLAVE")
            {
                textClave.Text = "";
                textClave.ForeColor = Color.LightGray;
                textClave.UseSystemPasswordChar = true;
            }
        }

        private void textClave_Leave(object sender, EventArgs e)
        {
            if (textClave.Text == "")
            {
                textClave.Text = "CLAVE";
                textClave.ForeColor = Color.White;
                textClave.UseSystemPasswordChar = false;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                
                logeo();
            Application.Run(new menus);

        }
        }
    }

