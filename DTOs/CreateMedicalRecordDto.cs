namespace HospitalManagementAPI.DTOs
{
    public class CreateMedicalRecordDto
    {
        public string Diagnosis { get; set; } = string.Empty;

        public string? Treatment { get; set; }

        public DateTime VisitDate { get; set; }

        public int AppointmentId { get; set; }
    }
}