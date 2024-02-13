using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WindagoWebApplication.Models {
    public class SocialMediaAccount {
        [Key]
        [ForeignKey("SocialMediaID")]
        public int Id { get; set; }
        public string WebSiteName { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public string WebSiteURL { get; set; }

    }
}
