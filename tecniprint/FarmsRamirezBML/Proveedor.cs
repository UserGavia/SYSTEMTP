using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Proveedor
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int IdProveedor { get; set; }
        public string NombreEmpresa { get; set; }
        public int CP { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public int NumeroInterior { get; set; }
        public int NumeroExterior { get; set; }
        public string Celular { get; set; }
        public string TelefonoFijo { get; set; }
        public string Correo { get; set; }
        public string PaginaWeb { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Proveedor()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@NombreEmpresa", NombreEmpresa);
            parametros.Add("@CP", CP);
            parametros.Add("@Estado", Estado);
            parametros.Add("@Ciudad", Ciudad);
            parametros.Add("@Municipio", Municipio);
            parametros.Add("@Colonia", Colonia);
            parametros.Add("@Calle", Calle);
            parametros.Add("@NumeroInterior", NumeroInterior);
            parametros.Add("@NumeroExterior", NumeroExterior);
            parametros.Add("@Celular", Celular);
            parametros.Add("@TelefonoFijo", TelefonoFijo);
            parametros.Add("@Correo", Correo);
            parametros.Add("@PaginaWeb", PaginaWeb);

            return dataAccess.Execute("stp_proveedores_add", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            
            parametros.Add("@IdProveedor", IdProveedor);
            parametros.Add("@NombreEmpresa", NombreEmpresa);
            parametros.Add("@CP", CP);
            parametros.Add("@Estado", Estado);
            parametros.Add("@Ciudad", Ciudad);
            parametros.Add("@Municipio", Municipio);
            parametros.Add("@Colonia", Colonia);
            parametros.Add("@Calle", Calle);
            parametros.Add("@NumeroInterior", NumeroInterior);
            parametros.Add("@NumeroExterior", NumeroExterior);
            parametros.Add("@Celular", Celular);
            parametros.Add("@TelefonoFijo", TelefonoFijo);
            parametros.Add("@Correo", Correo);
            parametros.Add("@PaginaWeb", PaginaWeb);

            return dataAccess.Execute("stp_proveedores_update", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdProveedor", IdProveedor);
            return dataAccess.Execute("stp_proveedores_delete", parametros);
        }

        public List<Proveedor> GetAll()
        {
            return dataAccess.Query<Proveedor>("stp_proveedores_getall");
        }

        public Proveedor GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdProveedor", IdProveedor);
            return dataAccess.QuerySingle<Proveedor>("stp_proveedores_getbyid", parametros);
        }

       
    }
}
