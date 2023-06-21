using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class TipoUsuario
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int IdTipoUsuario { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public TipoUsuario()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Descripcion", Descripcion);

            return dataAccess.Execute("stp_tipousuario_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdTipoUsuario", IdTipoUsuario);
            return dataAccess.Execute("stp_tipousuario_delete", parametros);
        }

        public List<TipoUsuario> GetAll()
        {
            return dataAccess.Query<TipoUsuario>("stp_tipousuario_getall");
        }

        public TipoUsuario GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdTipoUsuario", IdTipoUsuario);
            return dataAccess.QuerySingle<TipoUsuario>("stp_tipousuario_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdTipoUsuario", IdTipoUsuario);
            parametros.Add("@Descripcion", Descripcion);
            return dataAccess.Execute("stp_tipousuario_update", parametros);
        }
    }
}
