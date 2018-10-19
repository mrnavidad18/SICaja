using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SICaja.Clases
{
    public class PreventaFarmaciaCls
    {
        public string PREVCAB_NUM { get; set; }
        public string PREVDET_ID { get; set; }
        public string PREVDET_IDPRODUCTO { get; set; }
       
        public int PREVDET_ITEM { get; set; }
        public int PREVDET_CANTIDAD { get; set; }
        public decimal PREVDET_PRECIO { get; set; }
        public decimal PREVDET_DSCTO { get; set; }
        public decimal PREVDET_IMPORTE { get; set; }
        public string MED_DESCRIPCIONCORTA { get; set; }
        public string MED_FORMAFARMACEUTICA { get; set; }
        public decimal MED_PRECIOUNITARIOD { get; set; }
        
        //NroHistoriaClínica:
        public string NRO_HISTORIACLINICA { get; set; }
        public string NOMBRECLIENTE { get; set; }
        public string NRODOCUMENTOIDENTIDADCLI { get; set; }

        public string NOMBREEMPLEADOFARMACIA { get; set; }
        public string PREVCAB_NUMRECETA { get; set; }

        public decimal PREVCAB_TOTAL { get; set; }
        public string ESTADO_FACTURACIONFARMACIA { get; set; }

        
    }
}

