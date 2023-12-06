using DataAccessLayer.Data;
using DataAccessLayer.Reposatries;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Reposatories
{
    public class GenericReposatory<T> : IGenericReposatory<T> where T : class
    {
        private readonly Context context;

        public GenericReposatory(Context context)
        {
            this.context = context;
        }
       
        public void insert(T Entity)
        {
            context.Set<T>().Add(Entity);
        }

        public int save()
        {
            return context.SaveChanges();

        }
      


    }
}
