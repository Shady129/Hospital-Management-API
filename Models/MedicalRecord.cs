namespace HospitalManagementAPI.Models
{
    public class MedicalRecord
    {
        public int MedicalRecordId { get; set; }

        public string Diagnosis { get; set; } = string.Empty;

        public string? Treatment { get; set; }

        public DateTime VisitDate { get; set; }

        public int AppointmentId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public Appointment? Appointment { get; set; } = null!;


        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    }
}