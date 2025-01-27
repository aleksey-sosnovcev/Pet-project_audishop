namespace Pet_project_audishop.Data.Models
{
    public class Car
    {
        //модель для описания товара
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img {  get; set; }
        public ushort price {  get; set; }
        public bool isFavourite {  get; set; }
        public bool availble {  get; set; }
        public int categoryID { get; set; }
        public virtual Categories Categories { get; set; }
    }
}
