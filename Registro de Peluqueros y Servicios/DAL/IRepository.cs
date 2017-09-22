using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Peluqueros_y_Servicios
{
    interface IRepository<TEntity>:IDisposable where TEntity:class
    {
        TEntity Guardar(TEntity nuevo);
        bool Modificar(TEntity criterio);
        bool Eliminar(TEntity criterio);
        TEntity Buscar(Expression<Func<TEntity,bool>> criterio);
        List<TEntity> GetListTodo();
        List<TEntity> GetList(Expression<Func<TEntity,bool>> criterio);
    }
}
