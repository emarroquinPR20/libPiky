using System;
using static System.Console;
using System.Collections.Generic;
using libPiky.Entities;
using libPiky.Interfaces;

namespace libPiky.Controllers
{
    public class ControllerEntrada : IMantenimiento
    {
        
        private List<Entrada> listaEntradas = new List<Entrada>();
        public void Ingresar(object elemento)
        {
            this.listaEntradas.Add((Entrada)elemento);
        }
        public void Modificar()
        {

        }
        public void Eliminar(object elemento)
        {
            this.listaEntradas.Remove((Entrada)elemento);
        }
        public object Consultar(string id)
        {
            object resultado = new object();
            foreach (var item in listaEntradas)
            {
                if (item.IdEntrada.Equals(id))
                {
                    resultado = item;
                    break;
                }
            }
            return resultado;
        }
        public void Listar()
        {
            foreach (var item in listaEntradas)
            {
                WriteLine(item.ToString());
            }
        }
        
    }
}