using FarmsRamirezDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmsRamirezBML
{
    public class ConfigCotizazionUV
    {
        public static DataAccess dataAccess = DataAccess.Instance();
        public int IdConfCotizacionUV { get; set; }
        public int TiempoImpresion { get; set; }
        public TimeSpan TiempoPloteado { get; set; }
        public TimeSpan TiempoDepilado { get; set; }

    }
}
