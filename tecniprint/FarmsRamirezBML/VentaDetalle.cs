using Dapper;
using FarmsRamirezDAL;
using System.Data;

namespace FarmsRamirezBML
{
    class VentaDetalle
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int IdVentaDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public decimal Dc { get; set; }
        public decimal Dv { get; set; }
        public decimal Dv2 { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public VentaDetalle() { }

        public int Add(DataTable ventaDetalle)
        {
            DataTable dataTableVD = new DataTable();
            dataTableVD.Columns.Add("idVenta", typeof(int));
            dataTableVD.Columns.Add("idProducto", typeof(int));
            dataTableVD.Columns.Add("cantidad", typeof(int));
            dataTableVD.Columns.Add("precio", typeof(decimal));
            dataTableVD.Columns.Add("importe", typeof(decimal));
            dataTableVD.Columns.Add("dc", typeof(decimal));
            dataTableVD.Columns.Add("dv", typeof(decimal));
            dataTableVD.Columns.Add("dv2", typeof(decimal));
            dataTableVD.Columns.Add("descuento", typeof(decimal));
            dataTableVD.Columns.Add("total", typeof(decimal));

            foreach (DataRow item in ventaDetalle.Rows)
            {
                DataRow row = dataTableVD.NewRow();
                row["idVenta"] = IdVenta;
                row["idProducto"] = item["idProducto"];
                row["cantidad"] = item["cantidad"];
                row["precio"] = item["precio"];
                row["importe"] = item["importe"];
                row["dc"] = item["dc"];
                row["dv"] = item["dv"];
                row["dv2"] = item["dv2"];
                row["descuento"] = item["descuento"];
                row["total"] = item["total"];
                dataTableVD.Rows.Add(row);
            }

            var parametros = new DynamicParameters();
            parametros.Add("@ventasDetalle", dataTableVD, DbType.Object);
            return dataAccess.Execute("stp_ventasdetalle_add", parametros);

        }
    }
}
