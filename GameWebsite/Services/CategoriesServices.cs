namespace GameWebsite.Services
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly ApplicationDBContext _context;

        public CategoriesServices(ApplicationDBContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetAllCategories()
        {
            return _context.categories
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text)
                .ToList();
        }

    }
}
