using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trabajo_Final_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {


            if (txtRazonSocial.Text != "" && nudCuit.Value != 0 && nudFactura.Value != 0 && nudCodArticulo.Value !=0 && txtDescripcion.Text != "" && nudPrecio.Value !=0 && nudCantidad.Value !=0 && nudDescuento.Value != 0)
            {
                FileStream ArchivoCabeza = new FileStream("C:\\Users\\guido\\OneDrive\\Desktop\\Boss Final\\Trabajo Final 2.0\\Archivos del programa\\ArchivoCabeza.txt", FileMode.Append);
                FileStream ArchivoDetalle = new FileStream("C:\\Users\\guido\\OneDrive\\Desktop\\Boss Final\\Trabajo Final 2.0\\Archivos del programa\\ArchivoDetalle.txt", FileMode.Append);
                StreamWriter EscritorCabeza = new StreamWriter(ArchivoCabeza);
                StreamWriter EscritorDetalle = new StreamWriter(ArchivoDetalle);

                string RegistroCabeza = "";
                string RegistroDetalle = "";
                String[] VectorCabeza = new String[0];
                String[] VectorDetalle = new String[0];

                int NumeroFila = dgvFactura.Rows.Add();
                decimal SubTotal =0;
                //#######################################################################################################################################################################################//

                RegistroCabeza = nudFactura.Value + ";" + nudCuit.Value + ";" + txtRazonSocial.Text;
                RegistroDetalle = nudFactura.Value + ";" + nudCodArticulo.Value + ";" + txtDescripcion.Text + ";" + nudPrecio.Value + ";" + nudCantidad.Value + ";" + nudDescuento.Value;

                VectorCabeza = RegistroCabeza.Split(';');
                VectorDetalle = RegistroDetalle.Split(';');

                //#######################################################################################################################################################################################//

                decimal Precio = Convert.ToDecimal(VectorDetalle[3]);
                decimal Cantidad = Convert.ToDecimal(VectorDetalle[4]);
                decimal Descuento = Convert.ToDecimal(VectorDetalle[5]);
                SubTotal = Precio * Cantidad - (Precio * Descuento / 100 * Cantidad);

                dgvFactura.Rows[NumeroFila].Cells[0].Value = VectorDetalle[1];
                dgvFactura.Rows[NumeroFila].Cells[1].Value = VectorDetalle[2];
                dgvFactura.Rows[NumeroFila].Cells[2].Value = VectorDetalle[3];
                dgvFactura.Rows[NumeroFila].Cells[3].Value = VectorDetalle[4];
                dgvFactura.Rows[NumeroFila].Cells[4].Value = VectorDetalle[5];
                dgvFactura.Rows[NumeroFila].Cells[5].Value = SubTotal;

                RegistroDetalle = nudFactura.Value + ";" + nudCodArticulo.Value + ";" + txtDescripcion.Text + ";" + nudPrecio.Value + ";" + nudCantidad.Value + ";" + nudDescuento.Value+";"+SubTotal;

                //#######################################################################################################################################################################################//

                nudCodArticulo.Value = 0;
                txtDescripcion.Text = "";
                nudPrecio.Value = 0;
                nudCantidad.Value = 0;
                nudDescuento.Value = 0;

                //#######################################################################################################################################################################################//

                EscritorCabeza.WriteLine(RegistroCabeza);
                EscritorDetalle.WriteLine(RegistroDetalle);

                //#######################################################################################################################################################################################//


                EscritorDetalle.Close();
                EscritorCabeza.Close();
                ArchivoDetalle.Close();
                ArchivoCabeza.Close();

            }
            else
            {
                MessageBox.Show("No se cargaron todos los campos");
            }



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
