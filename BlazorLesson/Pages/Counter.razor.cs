using Microsoft.AspNetCore.Components;
using BlazorLesson.Repository;
using BlazorLesson.Models;

namespace BlazorLesson.Pages
{
    public partial class Counter
    {
        [Inject]
        public IGenericRepository<Game> _repository { get; set; }

        [CascadingParameter]
        public AppStyle Styles { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
