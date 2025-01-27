using Pet_project_audishop.Data.Models;

namespace Pet_project_audishop.Data.interfaces
{
    public interface ICarsCategories
    {
        IEnumerable<Categories> AllCategories { get; }
    }
}
