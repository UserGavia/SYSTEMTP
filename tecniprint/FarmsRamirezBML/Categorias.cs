using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Categorias
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Categorias()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Descripcion", Descripcion);

            return dataAccess.Execute("stp_categorias_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdCategoria", IdCategoria);
            return dataAccess.Execute("stp_categorias_delete", parametros);
        }

        public List<Categorias> GetAll()
        {
            return dataAccess.Query<Categorias>("stp_categorias_getall");
        }

        public Categorias GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdCategoria", IdCategoria);
            return dataAccess.QuerySingle<Categorias>("stp_categorias_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdCategoria", IdCategoria);
            parametros.Add("@Descripcion", Descripcion);
            return dataAccess.Execute("stp_categorias_update", parametros);
        }
    }
}
