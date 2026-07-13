namespace HospitalManagementAPI.DTOs
{
    public class CreateAppointmentDto
    {
        public DateTime AppointmentDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public string? Reason { get; set; }

        public string? Notes { get; set; }

        public int DoctorId { get; set; }

        public int PatientId { get; set; }
    }
}