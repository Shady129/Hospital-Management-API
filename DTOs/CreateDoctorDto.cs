namespace HospitalManagementAPI.DTOs
{
    public class CreateDoctorDto
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Specialization { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public int DepartmentId { get; set; }

        public bool IsActive { get; set; }
    }
}