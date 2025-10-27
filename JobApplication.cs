using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationTracker
{
    // Klass som beskriver en jobbansökan
    public class JobApplication
    {
        // Företagets namn
        public string CompanyName { get; set; }

        // Vilken tjänst man sökt
        public string PositionTitle { get; set; }

        // Status: t.ex. "Applied", "Interview", "Offer", "Rejected"
        public string Status { get; set; }

        // Datum när man skickade ansökan
        public DateTime ApplicationDate { get; set; }

        // Löneanspråk i kronor
        public int SalaryExpectation { get; set; }

        // Beräknar hur många dagar som gått sedan man sökte
        public int GetDaysSinceApplied()
        {
            return (DateTime.Today - ApplicationDate).Days;
        }

        // Kort sammanfattning som skrivs ut i konsolen
        public string GetSummary()
        {
            return $"{CompanyName} - {PositionTitle} | Status: {Status} | Sökt: {ApplicationDate:yyyy-MM-dd}";
        }
    }
}
