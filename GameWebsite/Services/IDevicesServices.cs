namespace GameWebsite.Services
{
    public interface IDevicesServices
    {
        IEnumerable<SelectListItem> GetAllDevices();
    }
}
