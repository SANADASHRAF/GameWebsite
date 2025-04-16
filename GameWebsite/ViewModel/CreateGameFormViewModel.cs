using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameWebsite.ViewModel
{
    public class CreateGameFormViewModel
    {
        public string Name { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; } =Enumerable.Empty<SelectListItem>();
        
        
        public List<int> selectedDevices { get; set; } = new List<int>();
        public IEnumerable<SelectListItem> Devices { get; set; } = Enumerable.Empty<SelectListItem>();
   
        public string Description { get; set; } = string.Empty;
        public IFormFile Cover { get; set; } = default!;
    }
}
