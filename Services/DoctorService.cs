using HospitalManagementAPI.Models;
using HospitalManagementAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HospitalManagementAPI.Services
{
    public class DoctorService
    {

        private readonly DoctorRepository _doctorRepository;

        public DoctorService(DoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }



        public async Task<IEnumerable<Doctor>> GetAllDoctorsAsync()
        {

            return await _doctorRepository.GetAllAsync();
        }



        public async Task<Doctor?> GetDoctorByIdAsync(int id)
        {
            return await _doctorRepository.GetByIdAsync(id);
        }



        public async Task AddDoctorAsync(Doctor doctor)
        {
            await _doctorRepository.AddAsync(doctor);

        }



        public async Task<bool>UpdateDoctorAsync(int id, Doctor doctor)
        {
            var existingDoctor = await _doctorRepository.GetByIdAsync(id);

            if(existingDoctor == null)
            {
                return false;
            }


            existingDoctor.FirstName= doctor.FirstName;
            existingDoctor.LastName= doctor.LastName;
            existingDoctor.Specialization = doctor.Specialization;
            existingDoctor.PhoneNumber = doctor.PhoneNumber;
            existingDoctor.Email = doctor.Email;
            existingDoctor.DepartmentId = doctor.DepartmentId;
            existingDoctor.IsActive = doctor.IsActive;


            return true;

        }



        public async Task<bool> DeleteDoctorAsync(int id)
        {
            var doctor = await _doctorRepository.GetByIdAsync(id);

            if (doctor == null)
            {
                return false;
            }



            await _doctorRepository.DeleteAsync(doctor);

            return true;
        }
    }
}
