using Registro_de_Peluqueros_y_Servicios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;


namespace Registro_de_Peluqueros_y_Servicios
{
    public class Repository<TENtity> : IRepository<TENtity> where TENtity : class
    {
        BarberShopDb context = null;
        public Repository()
        {
            context = new BarberShopDb();
        }

        public DbSet<TENtity>EntitySet
        {
            get
            {
                return context.Set<TENtity>();
            }
        }
        
        public TENtity Buscar(Expression<Func<TENtity, bool>> criterio)
        {
            TENtity result = null;

            try
            {
                result = EntitySet.FirstOrDefault(criterio);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public void Dispose()
        {
           if(context!=null)
            {
                context.Dispose();
            }
        }

        public bool Eliminar(TENtity criterio)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(criterio);
                EntitySet.Remove(criterio);
                result = context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public List<TENtity> GetList(Expression<Func<TENtity, bool>> criterio)
        {
            try
            {
                return EntitySet.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TENtity> GetListTodo()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TENtity Guardar(TENtity nuevo)
        {
            TENtity result = null;

            try
            {
                EntitySet.Add(nuevo);
                context.SaveChanges();
                result = nuevo;

            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public bool Modificar(TENtity criterio)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(criterio);
                context.Entry(criterio).State = EntityState.Modified;
                result =context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}