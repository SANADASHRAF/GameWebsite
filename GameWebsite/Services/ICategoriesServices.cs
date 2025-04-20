namespace GameWebsite.Services
{
    public interface ICategoriesServices
    {
       IEnumerable<SelectListItem> GetAllCategories();
    }
}
