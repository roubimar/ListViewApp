using System;

namespace ListViewApp.All.Models
{
    public class Prescription
    {
        public string ID { get; set; }
        public string Items { get; set; }
        public DateTime DateTime { get; set; }
        public string State { get; set; }
        public string Doctor { get; set; }
    }
}
