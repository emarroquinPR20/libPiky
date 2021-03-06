using System;
using static System.Console;
using System.Collections.Generic;

using com.Libreria.coreV1.Entities;
using com.Libreria.coreV1.Interfaces;

namespace com.Libreria.coreV1.Controllers
{
    public class ControllerVenta : IMantenimiento
    {

        private List<Venta> listaVentas = new List<Venta>();
        public void Ingresar(object elemento)
        {
            this.listaVentas.Add((Venta)elemento);
        }
        public void Modificar()
        {

        }
        public void Eliminar(object elemento)
        {
            this.listaVentas.Remove((Venta)elemento);
        }
        public object Consultar(string id)
        {
            object resultado = new object();
            foreach (var item in listaVentas)
            {
                if (item.IdVenta.Equals(id))
                {
                    resultado = item;
                    break;
                }
            }
            return resultado;
        }
        public void Listar()
        {
            foreach (var item in listaVentas)
            {
                WriteLine(item.ToString());
            }
        }
                
    }
}