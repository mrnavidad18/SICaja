using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using SICaja.Clases;

namespace SICaja.Controlador
{
    public class EmpleadoImpl
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["accesSIHE"].ConnectionString;
        private static SqlConnection oConexion = new SqlConnection(Cadena);

        public Empleado getInfoEmpleadoxDNI(string DNI)
        {
            Empleado empleadoCls= new Empleado();
            using (SqlCommand oComando = new SqlCommand("GETINFOEMPLEADO_X_DNI", oConexion))
            {
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Parameters.AddWithValue("@DNI", DNI);
                
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = oComando.ExecuteReader(CommandBehavior.SingleResult);
                    while (dr.Read())
                    {
                        empleadoCls = new Empleado();
                        empleadoCls.idEmp =Convert.ToInt32(dr[0]);
                        empleadoCls.NombreEmpleado = dr[1].ToString();
                    }
                    dr.Close();
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    oConexion.Close();
                    throw ex;
                }
                return empleadoCls;
            }
        }
    }
}
