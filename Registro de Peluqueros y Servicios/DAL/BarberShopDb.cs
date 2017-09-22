using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tarea_4.Entidades;

namespace Tarea_4.DAL
{
    public class BarberShopDb: DbContext
    {
        public BarberShopDb():base ("ConStr")
        {

        }

        public DbSet<Servicios> servicio { get; set; }
        public DbSet<Peluqueros> peluquero { get; set; }

    }
}