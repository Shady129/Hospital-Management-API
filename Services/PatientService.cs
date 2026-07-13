using HospitalManagementAPI.Models;
using HospitalManagementAPI.Repositories;

namespace HospitalManagementAPI.Services
{
    public class PatientService
    {


        private readonly PatientRepository _patientRepository;

        public PatientService(PatientRepository patientRepository)
        {

            _patientRepository = patientRepository;

        }




        public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
        {
            return await _patientRepository.GetAllAsync();
        }




        public async Task<Patient?> GetPatientByIdAsync(int id)
        {
            return await _patientRepository.GetByIdAsync(id);
            
        }




        public async Task AddPatientAsync(Patient patient)
        {
            await _patientRepository.AddAsync(patient);
         
        }




        public async Task<bool> UpdatePatientAsync(int id, Patient patient)
        {
            var existingPatient = await _patientRepository.GetByIdAsync(id);

            if (existingPatient == null)
                return false;

            existingPatient.FirstName = patient.FirstName;
            existingPatient.LastName = patient.LastName;
            existingPatient.Email = patient.Email;
            existingPatient.PhoneNumber = patient.PhoneNumber;
            existingPatient.DateOfBirth = patient.DateOfBirth;
            existingPatient.Gender = patient.Gender;
            existingPatient.Address = patient.Address;
            existingPatient.BloodType = patient.BloodType;

            await _patientRepository.UpdateAsync(existingPatient);

            return true;
        }





        public async Task<bool> DeletePatientAsync(int id)
        {

            var patient = await _patientRepository.GetByIdAsync(id);

            if(patient == null)
            
                return false;


            await _patientRepository.DeleteAsync(patient);


            return true;
        }

    }
}
