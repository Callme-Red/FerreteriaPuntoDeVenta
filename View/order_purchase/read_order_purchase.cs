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

namespace FerreteríaPuntoVenta.View.order_purchase
{
    public partial class read_order_purchase : Form
    {
        public read_order_purchase()
        {
            InitializeComponent();
        }

        private void read_order_purchase_Load(object sender, EventArgs e)
        {
            String cnn = ConnectionDB.MasterConnection.s_connectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                string consulta = "SELECT        TOP (100) PERCENT dbo.tbl_orden_compra.ocompra_codigo AS codigo_orden_compra, dbo.tbl_orden_compra.ocompra_fecha_registro AS fecha_registro, dbo.tbl_pedido_compra.pcompra_num_factura AS numero_factura_pedido_compra, dbo.cat_persona.persona_nombre AS proveedor_nombre, dbo.cat_usuario.usuario_nombre AS nombre_usuario, dbo.tbl_orden_compra.ocompra_num_factura AS num_factura_orden_compra, dbo.tbl_orden_compra.ocompra_descripcion AS descripcion, dbo.tbl_orden_compra.ocompra_subtotal AS sub_total, dbo.tbl_orden_compra.ocompra_descuento AS descuento, dbo.tbl_orden_compra.ocompra_impuesto AS impuesto, dbo.tbl_orden_compra.ocompra_total AS total, dbo.cat_metodo_pago.mp_nombre AS metodo_pago_nombre, dbo.cat_estado.estado_nombre AS estado FROM            dbo.cat_metodo_pago INNER JOIN dbo.cat_estado INNER JOIN dbo.tbl_orden_compra ON dbo.cat_estado.estado_codigo = dbo.tbl_orden_compra.ocompra_estado_id ON dbo.cat_metodo_pago.mp_codigo = dbo.tbl_orden_compra.ocompra_mp_id INNER JOIN dbo.cat_usuario ON dbo.tbl_orden_compra.ocompra_usr_id = dbo.cat_usuario.usuario_codigo INNER JOIN dbo.cat_persona INNER JOIN dbo.cat_proveedor ON dbo.cat_persona.persona_codigo = dbo.cat_proveedor.proveedor_persona_id ON dbo.tbl_orden_compra.ocompra_proveedor_id = dbo.cat_proveedor.proveedor_codigo INNER JOIN dbo.tbl_pedido_compra ON dbo.cat_proveedor.proveedor_codigo = dbo.tbl_pedido_compra.pcompra_proveedor_id AND dbo.tbl_orden_compra.ocompra_pedido_compra_id = dbo.tbl_pedido_compra.pcompra_codigo ORDER BY codigo_orden_compra DESC, fecha_registro DESC";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;


            }
                

        }
    }
}
