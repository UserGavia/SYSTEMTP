using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Usuario
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int IdUsuarios { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IdTipoUsuario { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Usuario()
        {
        }

        public Usuario Login()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Username", Username);
            parametros.Add("@Password", Password);
            return dataAccess.QuerySingleOrDefault<Usuario>("stp_usuarios_login", parametros);
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Nombres", Nombres);
            parametros.Add("@Apellidos", Apellidos);
            parametros.Add("@Username", Username);
            parametros.Add("@Password", Password);

            return dataAccess.Execute("stp_usuarios_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdUsuarios", IdUsuarios);
            return dataAccess.Execute("stp_usuarios_delete", parametros);
        }

        public List<Usuario> GetAll()
        {
            return dataAccess.Query<Usuario>("stp_usuarios_getall");
        }

        public Usuario GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdUsuarios", IdUsuarios);
            return dataAccess.QuerySingle<Usuario>("stp_usuarios_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdUsuarios", IdUsuarios);
            parametros.Add("@Nombres", Nombres);
            parametros.Add("@Apellidos", Apellidos);
            parametros.Add("@Username", Username);
            parametros.Add("@Password", Password);

            return dataAccess.Execute("stp_usuarios_update", parametros);
        }
    }
}
