namespace HospitalManagementAPI.Models
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }

        public string MedicationName { get; set; } = string.Empty;

        public string Dosage { get; set; } = string.Empty;

        public string? Frequency { get; set; }

        public string? Duration { get; set; }

        public string? Instructions { get; set; }

        public int MedicalRecordId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public MedicalRecord? MedicalRecord { get; set; } = null!;


    }
}