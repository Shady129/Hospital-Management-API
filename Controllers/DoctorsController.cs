using HospitalManagementAPI.DTOs;
using HospitalManagementAPI.Models;
using HospitalManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly DoctorService _doctorService;

        public DoctorsController(DoctorService doctorService)
        {
            _doctorService = doctorService;
        }



        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            var doctors = await _doctorService.GetAllDoctorsAsync();

            return Ok(doctors);
        }



        [HttpGet("{id}")]

        public async Task<IActionResult> GetDoctor(int id)
        {
            var doctor = await _doctorService.GetDoctorByIdAsync(id);

            if(doctor == null)
            {
                return NotFound();
            }


            return Ok(doctor);

        }


        [HttpPost]
        public async Task<IActionResult> AddDoctor(CreateDoctorDto dto)
        {
            Doctor doctor = new Doctor
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Specialization = dto.Specialization,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                DepartmentId = dto.DepartmentId,
                IsActive = dto.IsActive
            };

            await _doctorService.AddDoctorAsync(doctor);

            return CreatedAtAction(nameof(GetDoctor), new { id = doctor.DoctorId },doctor);
        }






        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDoctor(int id, Doctor doctor)
        {
            var update = await _doctorService.UpdateDoctorAsync(id, doctor);

            if(!update)
            {
                return NotFound();
            }

            return NoContent();

        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            var deleted = await _doctorService.DeleteDoctorAsync(id);


            if(!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}