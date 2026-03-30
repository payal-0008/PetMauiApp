using System;
using System.Collections.Generic;
using System.Text;

namespace PetMauiApp.Models
{
  
    public class Appointment
    {
        public string DoctorName { get; set; }
        public DateTime SelectedDate { get; set; }
        public string SelectedTime { get; set; }
    }
}
