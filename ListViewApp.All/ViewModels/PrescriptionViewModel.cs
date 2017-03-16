using ListViewApp.All.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewApp.All.ViewModels
{
    public class PrescriptionViewModel
    {
        #region PrescriptionDetail

        public string ID { get; set; }
        public string ID_128 { get; set; }
        public DateTime? Exposed { get; set; }
        public DateTime? Expiration { get; set; }
        public string State { get; set; }
        public string SMS_ID { get; set; }
        public int Repetitions { get; set; }
        public List<string> Symbols { get; set; }
        public List<int> Issues { get; set; }
        public List<int> Listings { get; set; }

        #endregion

        #region Cures
        public List<Cure> Cures;
        #endregion


        #region Notes
        public string PharmacistNote { get; set; }
        public string PatientNote { get; set; }
        #endregion


        #region Patient
        public string PatientName { get; set; }
        public string PatientNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        #endregion


        #region Doctor
        public string DoctorName { get; set; }
        public string Provider { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string IC { get; set; }
        public string Area { get; set; }
        #endregion
        
        public PrescriptionStatus Status { get; set; }

        public static Random RANDOM { get; set; } = new Random();

        public PrescriptionViewModel(Prescription prescription)
        {
            ID = prescription.ID;
            ID_128 = prescription.ID + "_128";

            Exposed = prescription.DateTime;

            DoctorName = prescription.Doctor;

            PatientNote = "Sed ut perspiciatis, unde omnis iste natus, totam rem aperi vitae dicta sunt, explicabo. Nemo , quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est, qui dolorem ipsum, quia dolor sit, amet, consectetur, adipisci veli";
            PharmacistNote = " At vero eos et accusamus et iusto odio dignissimos ducimus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet";

            DoctorName = prescription.Doctor;

            Issues = new List<int>() { 1, 5, 7, 2266665 };

            var len = RANDOM.Next(1, 3);
            for (int i = 0; i < len; i++)
            {
                var ran = RANDOM.Next(0, 3) * 2;
                Status |= ((PrescriptionStatus)(ran == 0 ? 1 : ran)); 
            }
        }
    }
}
