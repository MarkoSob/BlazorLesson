namespace BlazorLesson.Models
{
    public class AppStyle
    {
        public string Color { get; set; } = "blue";
        public List<string> WitcherWords { get; set; } = new List<string>()
        {
            new string("See you, elf"),
            new string("Hi, Witcher")
        };
        public List<TableListModels> TableStyles { get; set; } = new List<TableListModels>()
        {
            new TableListModels()
            {
                Text = "Table Dark", Value = "table-dark"
            },
            new TableListModels()
            {
                Text = "Table Striped", Value = "table-striped"
            },
            new TableListModels()
            {
                Text = "Table Bordered", Value = "table-bordered"
            }
        };
    }
}
