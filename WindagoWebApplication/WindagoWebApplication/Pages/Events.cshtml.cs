using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WindagoWebApplication.Pages
{
    public class EventsModel : PageModel
    {
        private ILogger<EventsModel> logger;

        public EventsModel(ILogger<EventsModel> logger) {
            this.logger = logger;
        }

        public void OnGetUpcomingEvents()
        {

        }
    }
}
