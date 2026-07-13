using HospitalManagementAPI.Data;
using HospitalManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementAPI.Repositories
{
    public class MedicalRecordRepository
    {


        private readonly AppDbContext _context;

        public MedicalRecordRepository(AppDbContext context)
        {
            _context = context;
        }




        public async Task<List<MedicalRecord>> GetAllMedicalRecordsAsync()
        {
            return await _context.MedicalRecords
                .Include(m => m.Appointment)
                .ToListAsync();
        }



        public async Task<MedicalRecord?> GetMedicalRecordByIdAsync(int id)
        {
            return await _context.MedicalRecords
                .Include(m => m.Appointment)
                .FirstOrDefaultAsync(m => m.MedicalRecordId == id);
        }




        public async Task AddMedicalRecordAsync(MedicalRecord medicalRecord)
        {
            _context.MedicalRecords.Add(medicalRecord);
            await _context.SaveChangesAsync();
        }




        public async Task UpdateMedicalRecordAsync(MedicalRecord medicalRecord)
        {
            _context.MedicalRecords.Update(medicalRecord);

            await _context.SaveChangesAsync();

        }







        public async Task<bool> DeleteMedicalRecordAsync(int id)
        {
            var medicalRecord = await _context.MedicalRecords.FindAsync(id);

            if (medicalRecord == null)
                return false;

            _context.MedicalRecords.Remove(medicalRecord);

            await _context.SaveChangesAsync();

            return true;
        }


    }
}
