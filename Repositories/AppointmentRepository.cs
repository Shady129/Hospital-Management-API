using HospitalManagementAPI.Data;
using HospitalManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementAPI.Repositories
{
    public class AppointmentRepository
    {

        private readonly AppDbContext _context;



        public AppointmentRepository(AppDbContext context)
        {
            _context = context;
        }





        public async Task<List<Appointment>> GetAllAppointmentsAsync()
        {
            return await _context.Appointments.Include(a => a.Doctor)
                                 .Include(a => a.Patient)
                                 .ToListAsync();
        }




        public async Task<Appointment?> GetAppointmentByIdAsync(int id)
        {
            return await _context.Appointments
             .Include(a => a.Doctor)
             .Include(a => a.Patient)
             .FirstOrDefaultAsync(a => a.AppointmentId == id);
        }





        public async Task AddAppointmentAsync(Appointment appointment)
        {
            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();
        }





        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            await _context.SaveChangesAsync();
        }







        public async Task<bool> DeleteAppointmentAsync(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);


            if (appointment == null)
                return false;


            _context.Appointments.Remove(appointment);

            await _context.SaveChangesAsync();


            return true;
        }


    }
}
