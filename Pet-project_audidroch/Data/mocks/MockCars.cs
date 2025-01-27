using Pet_project_audishop.Data.interfaces;
using Pet_project_audishop.Data.Models;

namespace Pet_project_audishop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategories _categoriesCars = new MockCategories();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { 
                        name = "Audi A6", 
                        shortDesc="",longDesc="",
                        img="",price = 45000, 
                        isFavourite=true,
                        availble = true,
                        Categories = _categoriesCars.AllCategories.First()
                    },
                    new Car {
                        name = "Audi A7",
                        shortDesc="",longDesc="",
                        img="",price = 65000,
                        isFavourite=true,
                        availble = true,
                        Categories = _categoriesCars.AllCategories.First()
                    }
                };
            } 
        }
        public IEnumerable<Car> getFawCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
