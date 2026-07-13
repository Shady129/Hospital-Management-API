namespace HospitalManagementAPI.DTOs
{
    public class CreatePrescriptionDto
    {
        public int MedicalRecordId { get; set; }

        public string MedicationName { get; set; } = string.Empty;

        public string Dosage { get; set; } = string.Empty;

        public string Frequency { get; set; } = string.Empty;

        public string Duration { get; set; } = string.Empty;

        public string? Instructions { get; set; }
    }
}