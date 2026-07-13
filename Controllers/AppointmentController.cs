using HospitalManagementAPI.DTOs;
using HospitalManagementAPI.Models;
using HospitalManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {

        private readonly AppointmentService _appointmentService;

        public AppointmentController(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
            
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAppointments()
        {
            var appointments = await _appointmentService.GetAllAppointmentsAsync();

            return Ok(appointments);
        }





        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppointment(int id)
        {
            var appointment = await _appointmentService.GetAppointmentByIdAsync(id);

            if (appointment == null)

                return NotFound();

            return Ok(appointment);
        }




        [HttpPost]
        public async Task<IActionResult> AddAppointment(CreateAppointmentDto dto)
        {
            Appointment appointment = new Appointment
            {
                AppointmentDate = dto.AppointmentDate,
                Status = dto.Status,
                Reason = dto.Reason,
                Notes = dto.Notes,
                DoctorId = dto.DoctorId,
                PatientId = dto.PatientId
            };

            await _appointmentService.AddAppointmentAsync(appointment);

            return CreatedAtAction(nameof(GetAppointment), new { id = appointment.AppointmentId }, appointment);
        }




        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAppointment(int id, Appointment appointment)
        {
            if (id != appointment.AppointmentId)

                return BadRequest();

            await _appointmentService.UpdateAppointmentAsync(appointment);


            return NoContent();

        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {


            var deleted = await _appointmentService.DeleteAppointmentAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();

        }



    }
   
}

