using System;
using static System.Console;
using System.Collections.Generic;

using com.Libreria.coreV1.Entities;
using com.Libreria.coreV1.Interfaces;

namespace com.Libreria.coreV1.Controllers
{
    public class ControllerArticulo : IMantenimiento
    {

        private List<Articulo> listaArticulos = new List<Articulo>();
        public void Ingresar(object elemento)
        {
            this.listaArticulos.Add((Articulo)elemento);
        }
        public void Modificar()
        {

        }
        public void Eliminar(object elemento)
        {
            this.listaArticulos.Remove((Articulo)elemento);
        }
        public object Consultar(string id)
        {
            object resultado = new object();
            foreach (var item in listaArticulos)
            {
                if (item.IdArticulo.Equals(id))
                {
                    resultado = item;
                    break;
                }
            }
            return resultado;
        }
        public void Listar()
        {
            foreach (var item in listaArticulos)
            {
                WriteLine(item.ToString());
            }
        }
        
    }
    
}