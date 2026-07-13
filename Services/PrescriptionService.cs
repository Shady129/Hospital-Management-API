using HospitalManagementAPI.Models;
using HospitalManagementAPI.Repositories;

namespace HospitalManagementAPI.Services
{
    public class PrescriptionService
    {

        private readonly PrescriptionRepository _prescriptionRepository;

        public PrescriptionService(PrescriptionRepository prescriptionRepository)
        {
            _prescriptionRepository = prescriptionRepository;

        }



        public async Task<List<Prescription>> GetAllPrescriptionsAsync()
        {
            return await _prescriptionRepository.GetAllPrescriptionsAsync();
        }



        public async Task<Prescription?> GetPrescriptionByIdAsync(int id)
        {
            return await _prescriptionRepository.GetPrescriptionByIdAsync(id);
        }



        public async Task AddPrescriptionAsync(Prescription prescription)
        {
            await _prescriptionRepository.AddPrescriptionAsync(prescription);
        }



        public async Task UpdatePrescriptionAsync(Prescription prescription)
        {
            await _prescriptionRepository.UpdatePrescriptionAsync(prescription);
        }



        public async Task DeletePrescriptionAsync(int id)
        {
            await _prescriptionRepository.DeletePrescriptionAsync(id);
        }

    }
}