using System.Diagnostics;
using WindagoWebApplication.Models.Events;

namespace WindagoWebApplication.DS {
    public class EventsDS {
        public EventsDS() { }
        public List<Event> RetrieveUpcomingActiveEvents() {
            var result = new List<Event>();
            try {
                //Retrieve all of the active (not cancelled) upcoming events
            } catch(Exception ex) {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return result;
        }

        public List<Event> RetrieveUpcomingCancelledEvents() {
            var result = new List<Event>();
            try {
                //Retrieve all of the upcoming cancelled events
            }catch(Exception ex) {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return result;
        }

        public List<Event> RetrieveArchivedEvents() {
            var result = new List<Event>();
            try {
                //Retrieve all of the past events (cancelled or non-cancelled)
            }catch(Exception ex) {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return result;
        }
    }
}
