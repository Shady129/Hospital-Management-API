using HospitalManagementAPI.DTOs;
using HospitalManagementAPI.Models;
using HospitalManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;




namespace HospitalManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PatientsController : ControllerBase
    {
        private readonly PatientService _patientService;



        public PatientsController(PatientService patientService)
        {
            _patientService = patientService;
        }



        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            var patiesnts = await _patientService.GetAllPatientsAsync();
            return Ok(patiesnts);
        }



        [HttpGet("id")]
        public async Task<IActionResult> GetPatient(int id)
        {
            var patiesnt = await _patientService.GetPatientByIdAsync(id);

            if (patiesnt == null)
            {
                return NotFound();
            }

            return Ok(patiesnt);

        }


        [HttpPost]
        public async Task<IActionResult> AddPatient(CreatePatientDto dto)
        {
            Patient patient = new Patient
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                DateOfBirth = dto.DateOfBirth,
                Gender = dto.Gender,
                Address = dto.Address,
                BloodType = dto.BloodType
            };

            await _patientService.AddPatientAsync(patient);

            return CreatedAtAction(nameof(GetPatient), new { id = patient.PatientId }, patient);
        }




        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatient(int id, Patient patient)
        {
            var updated = await _patientService.UpdatePatientAsync(id, patient);

            if (!updated)
            {
                return NotFound();
            }

            return NoContent();
        }





        [HttpDelete("{id}")]

        public async Task<IActionResult> DeletePatient(int id)
        {
            var deleted = await _patientService.DeletePatientAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
