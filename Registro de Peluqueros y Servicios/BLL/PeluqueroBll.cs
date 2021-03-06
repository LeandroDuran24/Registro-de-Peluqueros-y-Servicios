﻿using Registro_de_Peluqueros_y_Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;



namespace Registro_de_Peluqueros_y_Servicios
{
    public class PeluqueroBll
    {

        public static Peluqueros Guardar(Peluqueros nuevo)
        {
            Peluqueros retorno = null;
            using (var conn = new Repository<Peluqueros>())
            {
                retorno = conn.Guardar(nuevo);
            }
            return retorno;
        }

        public static Peluqueros Buscar(Expression<Func<Peluqueros,bool>>criterio)
        {
            Peluqueros retorno = null;
            using (var conn = new Repository<Peluqueros>())
            {
                retorno = conn.Buscar(criterio);
            }
            return retorno;

        }

        public static bool Modificar(Peluqueros criterio)
        {
            bool retorno = false;
            using(var conn = new Repository<Peluqueros>())
            {
                retorno = conn.Modificar(criterio);
            }
            return retorno;
        }

        public static bool Eliminar(Peluqueros criterio)
        {
            bool retorno = false;
            using (var conn = new Repository<Peluqueros>())
            {
                retorno = conn.Eliminar(criterio);
            }
            return retorno;
        }

        public static List<Peluqueros>GetList(Expression<Func<Peluqueros,bool>>criterio)
        {
            List<Peluqueros> lista = null;
            using (var conn = new Repository<Peluqueros>())
            {
                lista = conn.GetList(criterio).ToList();
            }
            return lista;
        }

        public static List<Peluqueros>GetListTodo()
        {
            List<Peluqueros> lista = null;
            using (var conn = new Repository<Peluqueros>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }
    }

}