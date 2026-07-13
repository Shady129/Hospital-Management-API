namespace HospitalManagementAPI.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; } = string.Empty;

        public string? Address { get; set; }

        public string? BloodType { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;



        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}