using System.Diagnostics;
using WindagoWebApplication.Models;

namespace WindagoWebApplication.DS {
    public class SocialDS {
        public SocialDS() { }
        public List<SocialMediaAccount> RetrieveSocialMediaAccts() {
            var result = new List<SocialMediaAccount>();
            try {
                //Call DAL to retrieve social media accounts along with information and links that are stored in the DB
            }catch(Exception ex) {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return result;
        }
    }
}
