using System;
using System.Collections.Generic;
using System.Linq;

namespace JobApplicationTracker
{
    public class JobManager
    {
        private readonly List<JobApplication> applications = new List<JobApplication>();

        public void AddApplication(JobApplication application)
        {
            applications.Add(application);
            Console.WriteLine("Ansökan tillagd.");
        }

        public void ShowAll()
        {
            if (applications.Count == 0)
            {
                Console.WriteLine("Inga ansökningar ännu.");
                return;
            }

            Console.WriteLine("\n--- Alla ansökningar ---");
            foreach (var app in applications)
                Console.WriteLine(app.GetSummary());
        }

        public void UpdateStatus(string companyName, string newStatus)
        {
            var app = applications.FirstOrDefault(a =>
                a.CompanyName.Equals(companyName, StringComparison.OrdinalIgnoreCase));

            if (app == null)
            {
                Console.WriteLine("Ingen ansökan hittades med det företagsnamnet.");
                return;
            }

            app.Status = newStatus;
            Console.WriteLine("Status uppdaterad.");
        }

        public void RemoveApplication(string companyName)
        {
            var app = applications.FirstOrDefault(a =>
                a.CompanyName.Equals(companyName, StringComparison.OrdinalIgnoreCase));

            if (app == null)
            {
                Console.WriteLine("Ingen ansökan hittades med det företagsnamnet.");
                return;
            }

            applications.Remove(app);
            Console.WriteLine("Ansökan borttagen.");
        }

        public IReadOnlyList<JobApplication> GetAll() => applications.AsReadOnly();
    }
}
