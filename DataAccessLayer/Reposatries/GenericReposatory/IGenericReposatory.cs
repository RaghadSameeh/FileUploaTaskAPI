using System.Linq.Expressions;

namespace DataAccessLayer.Reposatories
{
    public interface IGenericReposatory<T> where T : class
    {

        void insert(T Entity);
        int save();
    }
}
