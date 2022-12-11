using BlazorLesson.Models;

namespace BlazorLesson.Repository
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll ();
    }
}
