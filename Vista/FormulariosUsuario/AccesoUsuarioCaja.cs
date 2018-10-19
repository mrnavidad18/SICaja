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

using SICaja.Vista.FormulariosMantenimiento;



namespace SICaja.Vista.FormulariosUsuario
{
    public partial class AccesoUsuarioCaja : Form
    {
        public AccesoUsuarioCaja()
        {
            InitializeComponent();
            this.ActiveControl = txtCodCajero;
        }


        private void validarAcceso(string user, string clave)
        {
            CajeroImpl cajImpl = new CajeroImpl();
            var getCajero = cajImpl.validarAccesoUsuarioCAJA(user,clave);
            if (getCajero.NomCompletoEmp != null)
            {
                MessageBox.Show("Acceso OK");
            }
            else
            {
                MessageBox.Show("Acceso BAD");
            }

        }

        private void txtNombreCajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                validarAcceso(txtCodCajero.Text.Trim(), txtClaveAcceso.Text.Trim());
            }
        }
    }
}
