using HospitalManagementAPI.Models;
using HospitalManagementAPI.Repositories;



namespace HospitalManagementAPI.Services
{
    public class DepartmentService
    {

        private readonly DepartmentRepository _departmentRepository;

        public DepartmentService(DepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }



        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _departmentRepository.GetAllAsync();
        }



        public async Task<Department?> GetDepartmentByIdAsync(int id)
        {
            return await _departmentRepository.GetByIdAsync(id);
        }



        public async Task AddDepartmentAsync(Department department)
        {
            await _departmentRepository.AddAsync(department);
        }



        public async Task<bool> UpdateDepartmentAsync(int id, Department department)
        {
            var existingDepartment = await _departmentRepository.GetByIdAsync(id);

            if (existingDepartment == null)
            {
                return false;
            }

            existingDepartment.Name = department.Name;
            existingDepartment.Description = department.Description;
            existingDepartment.IsActive = department.IsActive;
            await _departmentRepository.UpdateAsync(existingDepartment);

            return true;
        }



        public async Task<bool> DeleteDepartmentAsync(int id)
        {
            var department = await _departmentRepository.GetByIdAsync(id);

            if (department == null)
            {
                return false;
            }

            await _departmentRepository.DeleteAsync(department);

    

            return true;
        }
    }
}