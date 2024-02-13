using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WindagoWebApplication.Pages
{
    public class SocialModel : PageModel
    {
        private readonly ILogger<SocialModel> _logger;

        public SocialModel(ILogger<SocialModel> logger) {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
