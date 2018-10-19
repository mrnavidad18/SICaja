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
    public class CajeroImpl
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["accesSIHE"].ConnectionString;
        private static SqlConnection oConexion = new SqlConnection(Cadena);

        public bool generarAccesoCajero(Cajero cajero)
        {
            try
            {
                bool resul = false;
                SqlCommand oComando = new SqlCommand("GENERARACCESO_CAJERO", oConexion);
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Parameters.AddWithValue("@CodCajero", cajero.CodCajero);
                oComando.Parameters.AddWithValue("@IdEmp", cajero.IdEmp);
                oComando.Parameters.AddWithValue("@clave", cajero.clave);
                oComando.Parameters.AddWithValue("@EstadoUsuario", "A");
                oConexion.Open();
                resul = oComando.ExecuteNonQuery() > 0;
                oConexion.Close();
                return resul;
            }
            catch (Exception ex)
            {
                oConexion.Close();
                throw ex;
            }

        }

        public List<Cajero> listarUsuariosCajeroX_Estado(string estadoUser)
        {

            List<Cajero> listaUsuarios = new List<Cajero>();
            using (SqlCommand oComando = new SqlCommand("LISTAR_USUARIOS_CAJEROS", oConexion))
            {

                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Parameters.AddWithValue("@EstadoUsuario", estadoUser);
                Cajero CajeroCls;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = oComando.ExecuteReader(CommandBehavior.SingleResult);
                    while (dr.Read())
                    {
                        CajeroCls = new Cajero();
                        CajeroCls.CodCajero = dr[0].ToString();                       
                        CajeroCls.IdEmp = Convert.ToInt32(dr[1]);                       
                        CajeroCls.EstadoUsuario = dr[2].ToString();                       
                        CajeroCls.NomCompletoEmp = dr[3].ToString();
                        CajeroCls.DNIEmp = dr[4].ToString();
                        listaUsuarios.Add(CajeroCls);
                    }
                    dr.Close();
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    oConexion.Close();
                    throw ex;

                }
                return listaUsuarios;
            }
        }
        public bool cambiarEstadoCajero(string codCajero, string estado)
        {
            try
            {
                bool resul = false;
                SqlCommand oComando = new SqlCommand("CAMBIARESTADO_USUARIOCAJERO", oConexion);
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Parameters.AddWithValue("@CodCajero", codCajero);
                oComando.Parameters.AddWithValue("@EstadoUsuario", estado);
                oConexion.Open();
                resul = oComando.ExecuteNonQuery() > 0;
                oConexion.Close();
                return resul;
            }
            catch (Exception ex)
            {
                oConexion.Close();
                throw ex;
            }

        }
        public bool RestablecerPasswordCajero(string codCajero, string clave)
        {
            try
            {
                bool resul = false;
                SqlCommand oComando = new SqlCommand("RESTABLECERCLAVE_USUARIOCAJERO", oConexion);
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Parameters.AddWithValue("@CodCajero", codCajero);
                oComando.Parameters.AddWithValue("@clave", clave);
                oConexion.Open();
                resul = oComando.ExecuteNonQuery() > 0;
                oConexion.Close();
                return resul;
            }
            catch (Exception ex)
            {
                oConexion.Close();
                throw ex;
            }
        }
        public int verificarUsuarioCreado(int IdEmp)
        {            
            try
            {
                int result = 0;
                SqlCommand oComando = new SqlCommand("VerificarUsuarioCreado", oConexion);
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Parameters.AddWithValue("@IdEmp", IdEmp);                         
                oConexion.Open();
                SqlDataReader dr = oComando.ExecuteReader(CommandBehavior.SingleResult);
                while (dr.Read())
                {                   
                    result= Convert.ToInt32(dr[0]);                    
                }
                dr.Close();
                oConexion.Close();

                return result;
            }
            catch (Exception ex)
            {
                oConexion.Close();
                throw ex;
            }
        }

        public Cajero validarAccesoUsuarioCAJA(string codCajeroAccess, string claveAccess)
        {
            Cajero GetCajero = new Cajero();
            using (SqlCommand oComando = new SqlCommand("ACCEDER_USUARIOCAJA", oConexion))
            {
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Parameters.AddWithValue("@CodCajero", codCajeroAccess);
                oComando.Parameters.AddWithValue("@clave", claveAccess);                
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = oComando.ExecuteReader(CommandBehavior.SingleResult);
                    while (dr.Read())
                    {
                        GetCajero.CodCajero = dr[0].ToString();
                        GetCajero.IdEmp = Convert.ToInt32(dr[1]);
                        GetCajero.EstadoUsuario = dr[2].ToString();
                        GetCajero.NomCompletoEmp = dr[3].ToString();
                        GetCajero.DNIEmp = dr[4].ToString();                                              
                    }
                    dr.Close();
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    oConexion.Close();
                    throw ex;
                }
                return GetCajero; 
            }
        }
    }
}
