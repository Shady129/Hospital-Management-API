namespace HospitalManagementAPI.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;


        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    }
}