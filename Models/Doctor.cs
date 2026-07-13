namespace HospitalManagementAPI.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }

        public string Specialization { get; set; } = string.Empty;

        public DateTime HireDate { get; set; }

        public int DepartmentId { get; set; }

        public Department? Department { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;


        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}