using System.Diagnostics;
using WindagoWebApplication.Models;

namespace WindagoWebApplication.DS {
    public class StoreDS {
        public StoreDS() { }
        public List<InventoryItem> RetrieveStoreMerch() {
            var result = new List<InventoryItem>();
            try{
                //Call the DAL to retrieve the data from SQL Server
            }catch(Exception ex) {
                Debug.WriteLine(ex.Message); //Eventually we will log using XLogger or ILogger
                throw;
            }
            return result;
        }

        public List<InventoryItem> RetrieveMusicProducts() {
            var result = new List<InventoryItem>();
            try {
                //Call the DAL to retrieve the data from SQL Server
            } catch(Exception ex) {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return result;
        }

        public List<InventoryItem> RetrieveAllInventory() {
            var result = new List<InventoryItem>();
            try {

            }catch(Exception ex) {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return result;
        }
    }
}
