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

namespace SICaja.Vista.FormulariosMantenimiento
{
    public partial class Mant_Cajeros : Form
    {
        public Mant_Cajeros()
        {
            InitializeComponent();            
        }
        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            generarCodigoCajero();
        }
        private void generarCodigoCajero()
        {
            try
            {
                txtResult.Text = "";
                if (txtNombreCajero.TextLength >= 1)
                {
                    string nombreCompletoCajero = txtNombreCajero.Text.Trim().ToUpper();

                    string[] letras = nombreCompletoCajero.Split(' ');

                    List<char> iniciales = new List<char>();
                    for (int i = 0; i < letras.Count(); i++)
                    {
                        iniciales.Add(char.Parse(letras[i].Substring(0, 1)));
                    }

                    foreach (var item in iniciales)
                    {
                        txtResult.Text += item;
                    }
                }
            }
            catch (Exception excep)
            {                
                //throw;
                MessageBox.Show(excep.Message);
            }
        }
        private void txtNombreCajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                generarCodigoCajero();
            }
        }
        private void txtNombreCajero_TextChanged(object sender, EventArgs e)
        {
            generarCodigoCajero();
        }
        private void Mant_Cajeros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string getDNI = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el N° DNI del empleado", "Mensaje al Usuario", "XXXXXXX");
                //txtIDEmp.Text = getDNI;
                getInfoEmpleadoxDNI(getDNI);
            }
        }
        private void getInfoEmpleadoxDNI(string dni)
        {
            try
            {
                EmpleadoImpl empImpl = new EmpleadoImpl();
                var empleado = empImpl.getInfoEmpleadoxDNI(dni);
                if (empleado.NombreEmpleado == null)
                {
                    MessageBox.Show("Empleado no encontrado", "Mensaje al Usuario",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtIDEmp.Text = "";
                    txtNombreCajero.Text = "";
                }
                else
                {
                    //verificar si usuario existe:
                    if (verificarUsuarioCreado(empleado.idEmp) == 1)
                    {
                        MessageBox.Show("Emplead@ ya tiene un usuario asociado", "Mensaje al Usuario",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        txtNombreCajero.Text = empleado.NombreEmpleado;
                        txtIDEmp.Text = empleado.idEmp.ToString();
                        txtClaveAcceso.Enabled = true;
                        this.ActiveControl = txtClaveAcceso;
                        txtClaveAcceso.Text = "larcoherrera";
                    }                    
                }                                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }            
        }
        private void btnGenerarAcceso_Click(object sender, EventArgs e)
        {
            generarAccesoCajero(txtResult.Text.Trim(), Convert.ToInt32(txtIDEmp.Text), txtClaveAcceso.Text.Trim());
        }
        private void generarAccesoCajero(string CodCajero,int idEmp , string claveAcceso)
        {            
            try
            {
                CajeroImpl cajImpl = new CajeroImpl();

                Cajero cajeroAdd = new Cajero();
                cajeroAdd.CodCajero = CodCajero;
                cajeroAdd.IdEmp = idEmp;
                cajeroAdd.clave = claveAcceso;

                if (cajImpl.generarAccesoCajero(cajeroAdd) == false)
                {
                    MessageBox.Show(this, "Ocurrió un error al generar el acceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    rbUsuariosInactivos.Checked = true;
                    rbUsuariosActivos.Checked = true;
                    MessageBox.Show(this, "Acceso creado", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                   // LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listarUsuariosCajeros(string estado)
        {
            CajeroImpl cajImpl = new CajeroImpl();
            var listado = cajImpl.listarUsuariosCajeroX_Estado(estado);

            dataGridView1.DataSource = listado;
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn CodCajero = new DataGridViewTextBoxColumn();
            CodCajero.HeaderText = "COD.";
            CodCajero.DataPropertyName = "CodCajero";
            CodCajero.Width = 80;
            dataGridView1.Columns.Add(CodCajero);

            DataGridViewTextBoxColumn NomCompletoEmp = new DataGridViewTextBoxColumn();
            NomCompletoEmp.HeaderText = "Nombre Empleado";
            NomCompletoEmp.DataPropertyName = "NomCompletoEmp";
            NomCompletoEmp.Width = 400;
            dataGridView1.Columns.Add(NomCompletoEmp);

            DataGridViewTextBoxColumn DNIEmp = new DataGridViewTextBoxColumn();
            DNIEmp.HeaderText = "DNI Empleado";
            DNIEmp.DataPropertyName = "DNIEmp";
            DNIEmp.Width = 90;
            dataGridView1.Columns.Add(DNIEmp);

            DataGridViewTextBoxColumn EstadoUsuario = new DataGridViewTextBoxColumn();
            EstadoUsuario.HeaderText = "Estado User";
            EstadoUsuario.DataPropertyName = "EstadoUsuario";
            EstadoUsuario.Width = 90;
            EstadoUsuario.Visible = false;
            dataGridView1.Columns.Add(EstadoUsuario);


        }
        private void rbUsuariosActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosActivos.Checked)
            {
                listarUsuariosCajeros("A");
                btnCambiarEstado.Enabled = false;
                btnRestablecerPass.Enabled = false;
            }
        }
        private void rbUsuariosInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuariosInactivos.Checked)
            {
                listarUsuariosCajeros("I");
                btnCambiarEstado.Enabled = false;
                btnRestablecerPass.Enabled = false;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
                return;
            else
            {
                if (dataGridView1.CurrentRow.Cells[3].Value.ToString().Equals("A"))
                {
                    btnRestablecerPass.Enabled = true;
                    btnCambiarEstado.Enabled = true;
                }
                else
                {
                    btnCambiarEstado.Enabled = true;
                    btnRestablecerPass.Enabled = false;
                }                                    
            }
        }
        private void cambiarEstadoUsuario(string codCajero, string estadoUser)
        {
            CajeroImpl cajImpl = new CajeroImpl();
            //string codCajero = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //string estadoCajero = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (cajImpl.cambiarEstadoCajero(codCajero, estadoUser) == false)
            {
                MessageBox.Show(this, "Ocurrió un error al cambiar el estado del usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, "Estado cambiado", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // LimpiarCampos();
            }          
        }
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            string codCajero = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string estadoCajero = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           
            if (estadoCajero.Equals("A"))
            {
                DialogResult dialogResult = MessageBox.Show("¿Está segur@ de inhabilitar este usuario?", "Cambiar Estado del Usuario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cambiarEstadoUsuario(codCajero,"I");
                    rbUsuariosInactivos.Checked=true;
                    //do Actualizar datagridView
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else if (estadoCajero.Equals("I"))
            {
                DialogResult dialogResult = MessageBox.Show("¿Está segur@ de habilitar este usuario?", "Cambiar Estado del Usuario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cambiarEstadoUsuario(codCajero, "A");
                    rbUsuariosActivos.Checked = true;
                    //do Actualizar Datagridview
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }                      
        }
        private void restablecerClaveUsuarioCajero(string codCajero,string clave)
        {
            CajeroImpl cajImpl = new CajeroImpl();
            //string codCajero = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //string estadoCajero = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (cajImpl.RestablecerPasswordCajero(codCajero, clave) == false)
            {
                MessageBox.Show(this, "Ocurrió un error al restablecer la contraseña de este usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbUsuariosActivos.Checked = true;
            }
            else
            {
                MessageBox.Show(this, "Contraseña Restablecida", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbUsuariosActivos.Checked = true;
                // LimpiarCampos();
            }          
        }
        private void btnRestablecerPass_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0) return;

            DialogResult dialogResult = MessageBox.Show("¿Está segur@ de Restablecer la contraseña para este usuario?", "Restablecer clave del Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                restablecerClaveUsuarioCajero(dataGridView1.CurrentRow.Cells[0].Value.ToString(), "larco2018");
               
            }
            else if (dialogResult == DialogResult.No)
            {                
            }
            

        }
        //
        private int verificarUsuarioCreado(int idEmpverify)
        {
            CajeroImpl cajImpl = new CajeroImpl();
            return cajImpl.verificarUsuarioCreado(idEmpverify);
        }
    }
}
