namespace GameWebsite.Services
{
    public class DevicesServices : IDevicesServices
    {
        private readonly ApplicationDBContext _context;
        public DevicesServices(ApplicationDBContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetAllDevices()
        {
            return _context.devices
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text)
                .ToList();
        }

    }
}
