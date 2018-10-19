using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SICaja.Clases;
using SICaja.Controlador;


namespace SICaja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
              
                string getFile =Microsoft.VisualBasic.Interaction.InputBox("Ingresa el N° de Preventa", "Mensaje al Usuario", "F1");
                textBox1.Text = getFile;
                getPreventaFarmacia(getFile);

            }
        }

        private void getPreventaFarmacia(string pBusqueda)
        {
            PreventaFarmaciaImpl preventaDAO =  new PreventaFarmaciaImpl();

            var listado = preventaDAO.getPreventaFarmacia(pBusqueda);         
                    
            foreach (var item in listado)
            {
                textBox2.Text = item.NRODOCUMENTOIDENTIDADCLI;
                textBox3.Text = item.NOMBRECLIENTE;
                textBox4.Text = item.ESTADO_FACTURACIONFARMACIA;
                textBox7.Text = item.PREVCAB_TOTAL.ToString("N2");
                dataGridView1.DataSource = listado;
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = false;              
            }
           
            dataGridView1.DataSource = listado;           
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;            

            DataGridViewTextBoxColumn PREVDET_IDPRODUCTO = new DataGridViewTextBoxColumn();
            PREVDET_IDPRODUCTO.HeaderText = "COD.";
            PREVDET_IDPRODUCTO.DataPropertyName = "PREVDET_IDPRODUCTO";
            PREVDET_IDPRODUCTO.Width = 80;
            dataGridView1.Columns.Add(PREVDET_IDPRODUCTO);

            DataGridViewTextBoxColumn MED_DESCRIPCIONCORTA = new DataGridViewTextBoxColumn();
            MED_DESCRIPCIONCORTA.HeaderText = "Concepto";
            MED_DESCRIPCIONCORTA.DataPropertyName = "MED_DESCRIPCIONCORTA";
            MED_DESCRIPCIONCORTA.Width = 500;
            dataGridView1.Columns.Add(MED_DESCRIPCIONCORTA);

            DataGridViewTextBoxColumn MED_FORMAFARMACEUTICA = new DataGridViewTextBoxColumn();
            MED_FORMAFARMACEUTICA.HeaderText = "Unidad.";
            MED_FORMAFARMACEUTICA.DataPropertyName = "MED_FORMAFARMACEUTICA";
            MED_FORMAFARMACEUTICA.Width = 80;
            dataGridView1.Columns.Add(MED_FORMAFARMACEUTICA);
            
            DataGridViewTextBoxColumn PREVDET_CANTIDAD = new DataGridViewTextBoxColumn();
            PREVDET_CANTIDAD.HeaderText = "Cantidad";
            PREVDET_CANTIDAD.DataPropertyName = "PREVDET_CANTIDAD";
            PREVDET_CANTIDAD.Width = 60;
            dataGridView1.Columns.Add(PREVDET_CANTIDAD);

            DataGridViewTextBoxColumn PREVDET_PRECIO = new DataGridViewTextBoxColumn();
            PREVDET_PRECIO.HeaderText = "Precio Unitario S/.";
            PREVDET_PRECIO.DataPropertyName = "PREVDET_PRECIO";
            PREVDET_PRECIO.Width = 80;
            dataGridView1.Columns.Add(PREVDET_PRECIO);

            DataGridViewTextBoxColumn PREVDET_DSCTO = new DataGridViewTextBoxColumn();
            PREVDET_DSCTO.HeaderText = "Dscto.";
            PREVDET_DSCTO.DataPropertyName = "PREVDET_DSCTO";
            PREVDET_DSCTO.Width = 80;
            dataGridView1.Columns.Add(PREVDET_DSCTO);

            DataGridViewTextBoxColumn PREVDET_IMPORTE = new DataGridViewTextBoxColumn();
            PREVDET_IMPORTE.HeaderText = "IMPORTE S/.";
            PREVDET_IMPORTE.DataPropertyName = "PREVDET_IMPORTE";
            PREVDET_IMPORTE.Width = 80;
            dataGridView1.Columns.Add(PREVDET_IMPORTE);

            DataGridViewTextBoxColumn PREVDET_IMPORTEs = new DataGridViewTextBoxColumn();
            PREVDET_IMPORTEs.HeaderText = "IGV 18 % " ;
            PREVDET_IMPORTEs.DataPropertyName = "CODIGO";
            PREVDET_IMPORTEs.Width = 80;
            dataGridView1.Columns.Add(PREVDET_IMPORTEs);


            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "N2";

            decimal totalIGV = 0;
            decimal totalPAGAR = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                double igv = 0.18;
                double igvIndividual = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value) * igv;
                totalIGV +=( Convert.ToDecimal(igvIndividual));
                
                MessageBox.Show(i.ToString());
                MessageBox.Show(igvIndividual.ToString());
                dataGridView1.Rows[i].Cells[7].Value = igvIndividual;
            }

            totalPAGAR = Convert.ToDecimal(textBox7.Text) + totalIGV;
            textBox6.Text = totalIGV.ToString();
            textBox5.Text = totalPAGAR.ToString();
            textBox8.Text = Math.Ceiling(62.888).ToString();
            //dataGridView1.Rows[7].Cells[0].Value = "Escribe tu valor";
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
