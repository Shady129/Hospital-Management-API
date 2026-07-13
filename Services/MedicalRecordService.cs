using HospitalManagementAPI.Models;
using HospitalManagementAPI.Repositories;

namespace HospitalManagementAPI.Services
{
    public class MedicalRecordService
    {

        private readonly MedicalRecordRepository _medicalRecordRepository;


        public MedicalRecordService(MedicalRecordRepository medicalRecordRepository)
        {
            _medicalRecordRepository = medicalRecordRepository;
        }


        public async Task<List<MedicalRecord>> GetAllMedicalRecordsAsync()
        {
            return await _medicalRecordRepository.GetAllMedicalRecordsAsync();
        }


        public async Task <MedicalRecord?> GetMedicalRecordByIdAsync(int id)
        {
            return await _medicalRecordRepository.GetMedicalRecordByIdAsync(id);
        }


        public async Task AddMedicalRecordAsync(MedicalRecord medicalRecord)
        {
            await _medicalRecordRepository.AddMedicalRecordAsync(medicalRecord);
        }


        public async Task UpdateMedicalRecordAsync(MedicalRecord medicalRecord)
        {
            await _medicalRecordRepository.UpdateMedicalRecordAsync(medicalRecord);
        }


        public async Task<bool> DeleteMedicalRecordAsync(int id)
        {
            return await _medicalRecordRepository.DeleteMedicalRecordAsync(id);
        }

    }
}
