using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmsRamirezBML
{
    public class Venta
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }
        public string Activo { get; set; }
        public Venta() { }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", IdCliente);
            parametros.Add("@fecha", Fecha);
            parametros.Add("@cantidad", Cantidad);
            parametros.Add("@importe", Importe);
            parametros.Add("@status", Activo);
            return dataAccess.Insert("stp_ventas_add", parametros, "idVenta");
        }
        public List<Venta> GetAll()
        {
            return dataAccess.Query<Venta>("stp_ventas_getall").ToList();
        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idVenta", IdVenta);
            return dataAccess.Execute("stp_ventas_delete", parametros);
        }

    }
}

