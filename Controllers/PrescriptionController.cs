using HospitalManagementAPI.DTOs;
using HospitalManagementAPI.Models;
using HospitalManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
 
            private readonly PrescriptionService _prescriptionService;

            public PrescriptionController(PrescriptionService prescriptionService)
            {
                _prescriptionService = prescriptionService;
            }



            [HttpGet]
            public async Task<IActionResult> GetAllPrescriptions()
            {
                var prescriptions = await _prescriptionService.GetAllPrescriptionsAsync();
                return Ok(prescriptions);
            }



            [HttpGet("{id}")]
            public async Task<IActionResult> GetPrescription(int id)
            {
                var prescription = await _prescriptionService.GetPrescriptionByIdAsync(id);

                if (prescription == null)
                    return NotFound();

                return Ok(prescription);
            }



        [HttpPost]
        public async Task<IActionResult> AddPrescription(CreatePrescriptionDto dto)
        {
            Prescription prescription = new Prescription
            {
                MedicalRecordId = dto.MedicalRecordId,
                MedicationName = dto.MedicationName,
                Dosage = dto.Dosage,
                Frequency = dto.Frequency,
                Duration = dto.Duration,
                Instructions = dto.Instructions
            };

            await _prescriptionService.AddPrescriptionAsync(prescription);

            return CreatedAtAction(nameof(GetPrescription), new { id = prescription.PrescriptionId }, prescription);
        }



        [HttpPut("{id}")]
            public async Task<IActionResult> UpdatePrescription(int id, Prescription prescription)
            {
                if (id != prescription.PrescriptionId)
                    return BadRequest();

                await _prescriptionService.UpdatePrescriptionAsync(prescription);

                return NoContent();
            }



            [HttpDelete("{id}")]
            public async Task<IActionResult> DeletePrescription(int id)
            {
                await _prescriptionService.DeletePrescriptionAsync(id);

                return NoContent();
            }

    }
}
