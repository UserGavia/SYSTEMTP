using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Permisos
    {
        private static DataAccess dataAccess = DataAccess.Instance();
        public int IdTipoUsuario { get; set; }
        public int IdPermisos { get; set; }
        public string Menu { get; set; }
        public string SubMenu { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Permisos()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Menu", Menu);
            parametros.Add("@SubMenu", SubMenu);

            return dataAccess.Execute("stp_permisos_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdPermisos", IdPermisos);
            return dataAccess.Execute("stp_permisos_delete", parametros);
        }
        public static List<Permisos> GetAll(int IdTipoUsuario)
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdRol", IdTipoUsuario);
            return dataAccess.Query<Permisos>("stp_permisos_getall");
        }

        public Permisos GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdPermisos", IdPermisos);
            return dataAccess.QuerySingle<Permisos>("stp_permisos_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Menu", Menu);
            parametros.Add("@SubMenu", SubMenu);
            return dataAccess.Execute("stp_permisos_update");
        }
    }
}
