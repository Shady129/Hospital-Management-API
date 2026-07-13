using HospitalManagementAPI.Data;
using HospitalManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementAPI.Repositories
{
    public class DoctorRepository
    {

        private readonly AppDbContext _context;



        public DoctorRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<List<Doctor>> GetAllAsync()
        {
            return await _context.Doctors.ToListAsync();
        }


        public async Task<Doctor?> GetByIdAsync(int id)
        {
            return await _context.Doctors.FindAsync(id);
        }



        public async Task AddAsync(Doctor doctor) 
        {
            await _context.Doctors.AddAsync(doctor);
            await _context.SaveChangesAsync();
        }





        public async Task UpdateAsync(Doctor doctor)
        {
            _context.Doctors.Update(doctor);
            await _context.SaveChangesAsync();
        }



        public async Task DeleteAsync(Doctor doctor)
        {
            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();
        }


    }
}
