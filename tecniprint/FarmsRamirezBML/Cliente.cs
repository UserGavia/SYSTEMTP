using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Cliente
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Celular { get; set; }
        public string TelefonoFijo { get; set; }
        public string Correo { get; set; }
        public int CP { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public int NumeroInterior { get; set; }
        public int NumeoExterior { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Cliente()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Nombres", Nombres);
            parametros.Add("@ApellidoPaterno", ApellidoPaterno);
            parametros.Add("@ApellidoMaterno", ApellidoMaterno);
            parametros.Add("@Celular", Celular);
            parametros.Add("@TelefonoFijo", TelefonoFijo);
            parametros.Add("@Correo", Correo);
            parametros.Add("@CP", CP);
            parametros.Add("@Estado", Estado);
            parametros.Add("@Ciudad", Ciudad);
            parametros.Add("@Municipio", Municipio);
            parametros.Add("@Colonia", Colonia);
            parametros.Add("@Calle", Calle);
            parametros.Add("@NumeroInterior", NumeroInterior);
            parametros.Add("@NumeroExterior", NumeoExterior);

            return dataAccess.Execute("stp_clientes_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdCliente", IdCliente);
            return dataAccess.Execute("stp_clientes_delete", parametros);
        }

        public List<Cliente> GetAll()
        {
            return dataAccess.Query<Cliente>("stp_clientes_getall");
        }
        public Cliente GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdCliente", IdCliente);
            return dataAccess.QuerySingle<Cliente>("stp_clientes_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdCliente", IdCliente);
            parametros.Add("@Nombres", Nombres);
            parametros.Add("@ApellidoPaterno", ApellidoPaterno);
            parametros.Add("@ApellidoMaterno", ApellidoMaterno);
            parametros.Add("@Celular", Celular);
            parametros.Add("@TelefonFijo", TelefonoFijo);
            parametros.Add("@Correo", Correo);
            parametros.Add("@CP", CP);
            parametros.Add("@Estado", Estado);
            parametros.Add("@Ciudad", Ciudad);
            parametros.Add("@Municipio", Municipio);
            parametros.Add("@Colonia", Colonia);
            parametros.Add("@Calle", Calle);
            parametros.Add("@NumeroInterior", NumeroInterior);
            parametros.Add("@NumeroExterior", NumeoExterior);

            return dataAccess.Execute("stp_clientes_update", parametros);
        }
    }
}
