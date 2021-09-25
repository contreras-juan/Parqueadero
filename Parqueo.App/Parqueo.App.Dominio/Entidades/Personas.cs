using System;
namespace Parqueo.App.Dominio
{
    public class Personas
    {
        public string Id {get;set;}
        public string Nombre {get;set;}
        public string Apellido{get;set;}
        public string CorreoElectronico {get;set;}
        public string Telefono {get;set;}
        public Vehiculos Vehiculo {get;set;}
    }
}