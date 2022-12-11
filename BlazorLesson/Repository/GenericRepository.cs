using BlazorLesson.Models;

namespace BlazorLesson.Repository
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        private IEnumerable<T> _items;

        public GenericRepository(IEnumerable<T> items)
        {
            _items = items;
        }
        public IEnumerable<T> GetAll()
        {
            return _items;
        }
    }
}
