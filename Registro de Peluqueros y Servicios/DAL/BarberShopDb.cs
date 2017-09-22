using System.Data.Entity;

namespace Registro_de_Peluqueros_y_Servicios
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