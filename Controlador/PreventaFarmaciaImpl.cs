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
    public class PreventaFarmaciaImpl
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["accesSIHE"].ConnectionString;
        private static SqlConnection oConexion = new SqlConnection(Cadena);


        public List<PreventaFarmaciaCls> getPreventaFarmacia(string PBusqueda)
        {

            List<PreventaFarmaciaCls> ListPreventa = new List<PreventaFarmaciaCls>();
            using (SqlCommand oComando = new SqlCommand("SP_GETPREVENTA_X_ID", oConexion))
            {

                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Parameters.AddWithValue("@PBusqueda", PBusqueda);
                PreventaFarmaciaCls PreventaFarmaciaCls;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = oComando.ExecuteReader(CommandBehavior.SingleResult);
                    while (dr.Read())
                    {
                        PreventaFarmaciaCls = new PreventaFarmaciaCls();
                        PreventaFarmaciaCls.PREVCAB_NUM = dr[0].ToString();
                        
                        PreventaFarmaciaCls.PREVDET_ID = dr[1].ToString();
                        PreventaFarmaciaCls.PREVDET_IDPRODUCTO = dr[2].ToString();
                        PreventaFarmaciaCls.PREVDET_ITEM = Convert.ToInt32(dr[3]);
                        PreventaFarmaciaCls.PREVDET_CANTIDAD =Convert.ToInt32( dr[4]);
                        PreventaFarmaciaCls.PREVDET_PRECIO = Convert.ToDecimal(dr[5]);
                        PreventaFarmaciaCls.PREVDET_DSCTO = Convert.ToDecimal(dr[6]);
                        PreventaFarmaciaCls.PREVDET_IMPORTE = Convert.ToDecimal(dr[7]);

                        PreventaFarmaciaCls.MED_DESCRIPCIONCORTA = dr[8].ToString();
                        PreventaFarmaciaCls.MED_FORMAFARMACEUTICA = dr[9].ToString();
                        PreventaFarmaciaCls.MED_PRECIOUNITARIOD = Convert.ToDecimal(dr[10]);
                        PreventaFarmaciaCls.NRO_HISTORIACLINICA = dr[11].ToString();
                        PreventaFarmaciaCls.NOMBRECLIENTE = dr[12].ToString();
                        PreventaFarmaciaCls.NRODOCUMENTOIDENTIDADCLI = dr[13].ToString();
                        PreventaFarmaciaCls.NOMBREEMPLEADOFARMACIA = dr[14].ToString();
                        PreventaFarmaciaCls.PREVCAB_NUMRECETA = dr[15].ToString();


                        PreventaFarmaciaCls.PREVCAB_TOTAL = Convert.ToDecimal(dr[16]);
                        PreventaFarmaciaCls.ESTADO_FACTURACIONFARMACIA = dr[17].ToString();

                        ListPreventa.Add(PreventaFarmaciaCls);
                    }
                    dr.Close();
                    oConexion.Close();
                }
                catch (Exception ex )
                {
                    oConexion.Close();
                    throw ex;
                    
                }
                return ListPreventa;
            }
        }




    }
}
