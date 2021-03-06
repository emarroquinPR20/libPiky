using System;
namespace com.Libreria.coreV1.Entities
{
    public class Proveedor
    {
        public string IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Proveedor()
        {
            IdProveedor = GeneraId();
        }
        public Proveedor(string nombre, string documento, string direccion, string correo, string telefono)
        {
            IdProveedor = GeneraId();
            Nombre = nombre;
            Documento = documento;
            Direccion = direccion;
            Correo = correo;
            Telefono = telefono;
        }

        private string GeneraId()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public override string ToString()
        {
            return $"{{\"Id\": \"{this.IdProveedor}\", \"Nombre\": \"{this.Nombre}\", \"Documento\": \"{this.Documento}\", \"Dirección\": \"{this.Direccion}\", \"Correo\": \"{this.Correo}\", \"Telefóno\": \"{this.Telefono}\"}}";
        }

    }
}