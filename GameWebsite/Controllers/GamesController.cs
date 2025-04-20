

namespace GameWebsite.Controllers
{
    public class GamesController : Controller
    {
        private readonly ApplicationDBContext _context;

        public GamesController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreateGameFormViewModel ViewModel = new()
            {
                Categories = _context.categories
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text)
                .ToList(),

                Devices = _context.devices
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text)
                .ToList()
            };
            return View(ViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateGameFormViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            //save
            return View();
        }
    }
}
