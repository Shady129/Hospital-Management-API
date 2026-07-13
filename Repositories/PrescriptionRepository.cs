using HospitalManagementAPI.Data;
using HospitalManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementAPI.Repositories
{
    public class PrescriptionRepository
    {

        private readonly AppDbContext _context;



        public PrescriptionRepository(AppDbContext context)
        {
            _context = context;
        }





        public async Task<List<Prescription>> GetAllPrescriptionsAsync()
        {
            return await _context.Prescriptions
                .Include(p => p.MedicalRecord)
                .ToListAsync();
        }




        public async Task<Prescription?> GetPrescriptionByIdAsync(int id)
        {
            return await _context.Prescriptions
                           .Include(p => p.MedicalRecord)
                           .FirstOrDefaultAsync(P => P.PrescriptionId == id);
        }




        public async Task AddPrescriptionAsync(Prescription prescription)
        {
            await _context.Prescriptions.AddAsync(prescription);
            await _context.SaveChangesAsync();
        }



        public async Task UpdatePrescriptionAsync(Prescription prescription)
        {
            _context.Prescriptions.Update(prescription);
            await _context.SaveChangesAsync();
        }







        public async Task<bool> DeletePrescriptionAsync(int id)
        {
            var prescription = await _context.Prescriptions.FindAsync(id);

            if (prescription == null)
                return false;

            _context.Prescriptions.Remove(prescription);
            await _context.SaveChangesAsync();

            return true;
        }


    }
}
