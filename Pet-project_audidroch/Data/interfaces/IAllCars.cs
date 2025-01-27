using Pet_project_audishop.Data.Models;

namespace Pet_project_audishop.Data.interfaces
{
    public interface IAllCars
    { 
        //все машины
        IEnumerable<Car> Cars { get; }
        //машины у которых isFaworite == true
        IEnumerable<Car> getFawCars { get; set; }
        //машины по конкретному айди
        Car getObjectCar(int carId);
    }
}
