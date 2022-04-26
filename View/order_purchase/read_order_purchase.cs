using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace FerreteríaPuntoVenta.View.order_purchase
{
    public partial class read_order_purchase : Form
    {
        public read_order_purchase()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void read_order_purchase_Load(object sender, EventArgs e)
        {
            String cnn = ConnectionDB.MasterConnection.s_connectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                string consulta = "SELECT        TOP (100) PERCENT dbo.tbl_orden_compra.ocompra_codigo AS Codigo, dbo.tbl_orden_compra.ocompra_fecha_registro AS Fecha_registro,  dbo.tbl_pedido_compra.pcompra_num_factura AS Numero_factura_Pedido, dbo.cat_persona.persona_nombre AS Proveedor_nombre, dbo.cat_usuario.usuario_nombre AS Nombre_usuario,   dbo.tbl_orden_compra.ocompra_num_factura AS Numero_factura_Orden, dbo.tbl_orden_compra.ocompra_descripcion AS Descripcion, dbo.tbl_orden_compra.ocompra_subtotal AS Sub_total,  dbo.tbl_orden_compra.ocompra_descuento AS Descuento, dbo.tbl_orden_compra.ocompra_impuesto AS Impuesto, dbo.tbl_orden_compra.ocompra_total AS Total, dbo.cat_metodo_pago.mp_nombre AS Metodo_pago, dbo.cat_estado.estado_nombre AS Estado FROM    dbo.cat_metodo_pago INNER JOIN   dbo.cat_estado INNER JOIN dbo.tbl_orden_compra ON dbo.cat_estado.estado_codigo = dbo.tbl_orden_compra.ocompra_estado_id ON dbo.cat_metodo_pago.mp_codigo = dbo.tbl_orden_compra.ocompra_mp_id INNER JOIN  dbo.cat_usuario ON dbo.tbl_orden_compra.ocompra_usr_id = dbo.cat_usuario.usuario_codigo INNER JOIN  dbo.cat_persona INNER JOIN dbo.cat_proveedor ON dbo.cat_persona.persona_codigo = dbo.cat_proveedor.proveedor_persona_id ON dbo.tbl_orden_compra.ocompra_proveedor_id = dbo.cat_proveedor.proveedor_codigo INNER JOIN dbo.tbl_pedido_compra ON dbo.cat_proveedor.proveedor_codigo = dbo.tbl_pedido_compra.pcompra_proveedor_id AND dbo.tbl_orden_compra.ocompra_pedido_compra_id = dbo.tbl_pedido_compra.pcompra_codigo ORDER BY Codigo DESC, fecha_registro DESC";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;


            }
                

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void read_order_purchase_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button_minim_Click(object sender, EventArgs e)
        {
            create_order_purchase ventana1 = new create_order_purchase();
            ventana1.Show();
            
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            String cnn = ConnectionDB.MasterConnection.s_connectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                string consulta = "SELECT        TOP (100) PERCENT dbo.tbl_orden_compra.ocompra_codigo AS Codigo, dbo.tbl_orden_compra.ocompra_fecha_registro AS Fecha_registro,  dbo.tbl_pedido_compra.pcompra_num_factura AS Numero_factura_Pedido, dbo.cat_persona.persona_nombre AS Proveedor_nombre, dbo.cat_usuario.usuario_nombre AS Nombre_usuario,   dbo.tbl_orden_compra.ocompra_num_factura AS Numero_factura_Orden, dbo.tbl_orden_compra.ocompra_descripcion AS Descripcion, dbo.tbl_orden_compra.ocompra_subtotal AS Sub_total,  dbo.tbl_orden_compra.ocompra_descuento AS Descuento, dbo.tbl_orden_compra.ocompra_impuesto AS Impuesto, dbo.tbl_orden_compra.ocompra_total AS Total, dbo.cat_metodo_pago.mp_nombre AS Metodo_pago, dbo.cat_estado.estado_nombre AS Estado FROM    dbo.cat_metodo_pago INNER JOIN   dbo.cat_estado INNER JOIN dbo.tbl_orden_compra ON dbo.cat_estado.estado_codigo = dbo.tbl_orden_compra.ocompra_estado_id ON dbo.cat_metodo_pago.mp_codigo = dbo.tbl_orden_compra.ocompra_mp_id INNER JOIN  dbo.cat_usuario ON dbo.tbl_orden_compra.ocompra_usr_id = dbo.cat_usuario.usuario_codigo INNER JOIN  dbo.cat_persona INNER JOIN dbo.cat_proveedor ON dbo.cat_persona.persona_codigo = dbo.cat_proveedor.proveedor_persona_id ON dbo.tbl_orden_compra.ocompra_proveedor_id = dbo.cat_proveedor.proveedor_codigo INNER JOIN dbo.tbl_pedido_compra ON dbo.cat_proveedor.proveedor_codigo = dbo.tbl_pedido_compra.pcompra_proveedor_id AND dbo.tbl_orden_compra.ocompra_pedido_compra_id = dbo.tbl_pedido_compra.pcompra_codigo ORDER BY Codigo DESC, fecha_registro DESC";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
