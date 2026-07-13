using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementAPI.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public string? Reason { get; set; }

        public string? Notes { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }


        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        public Doctor? Doctor { get; set; } = null!;

        public Patient? Patient { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public MedicalRecord? MedicalRecord { get; set; }
    }
}