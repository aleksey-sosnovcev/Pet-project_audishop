using Pet_project_audishop.Data.interfaces;
using Pet_project_audishop.Data.Models;

namespace Pet_project_audishop.Data.mocks
{
    //реализуем интерфейс для работы с категориями
    public class MockCategories : ICarsCategories
    {
        public IEnumerable<Categories> AllCategories
        {
            get 
            {
                return new List<Categories>
                {
                    new Categories {categoryName = "Полноприводные", desc = "Quattro - система полного привода" },
                    new Categories {categoryName = "Переднеприводные", desc = "А с Quattro гораздо лучше" }
                };
            }
        }

    }
}
