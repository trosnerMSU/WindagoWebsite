using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WindagoWebApplication.Pages {
    public class StoreModel : PageModel {
        private ILogger<StoreModel> _logger;
        public StoreModel(ILogger<StoreModel> logger) {
            _logger = logger;
        }
        public void OnGetMerch() {
            
        }

        public void OnGetMusicProducts() {

        }
    }
}
