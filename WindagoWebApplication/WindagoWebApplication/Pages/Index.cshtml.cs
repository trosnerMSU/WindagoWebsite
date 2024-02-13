using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace WindagoWebApplication.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        private Boolean isChecked = false;

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public void OnGetBasePage() {
            StringBuilder sb = new StringBuilder();
        }

    }
}