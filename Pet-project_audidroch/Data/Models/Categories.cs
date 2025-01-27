namespace Pet_project_audishop.Data.Models
{
    public class Categories
    {
        //модель для описания категорий
        public int id {  get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }
        public List<Car> Cars {  get; set; } 


    }
}
