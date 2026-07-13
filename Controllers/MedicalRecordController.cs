using HospitalManagementAPI.DTOs;
using HospitalManagementAPI.Models;
using HospitalManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRecordController:ControllerBase
    {


        private readonly MedicalRecordService _medicalRecordService;

        public MedicalRecordController(MedicalRecordService medicalRecordService)
        {
            _medicalRecordService = medicalRecordService;
        }



        [HttpGet]
        public async Task<IActionResult> GetAllMedicalRecords()
        {
            var medicalRecords = await _medicalRecordService.GetAllMedicalRecordsAsync();
            return Ok(medicalRecords);
        }



        [HttpGet("{id}")]

        public async Task<IActionResult> GetMedicalRecord(int id)
        {
            var medicalRecord = await _medicalRecordService.GetMedicalRecordByIdAsync(id);

            if (medicalRecord == null)
                return NotFound();

            return Ok(medicalRecord);
        }




        [HttpPost]
        public async Task<IActionResult> AddMedicalRecord(CreateMedicalRecordDto dto)
        {
            MedicalRecord medicalRecord = new MedicalRecord
            {
                Diagnosis = dto.Diagnosis,
                Treatment = dto.Treatment,
                VisitDate = dto.VisitDate,
                AppointmentId = dto.AppointmentId
            };

            await _medicalRecordService.AddMedicalRecordAsync(medicalRecord);

            return CreatedAtAction(nameof(GetMedicalRecord), new { id = medicalRecord.MedicalRecordId }, medicalRecord);
        }




        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMedicalRecord(int id, MedicalRecord medicalRecord)
        {
            if (id != medicalRecord.MedicalRecordId)
                return BadRequest();

            await _medicalRecordService.UpdateMedicalRecordAsync(medicalRecord);

            return NoContent();
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicalRecord(int id)
        {
            var deleted = await _medicalRecordService.DeleteMedicalRecordAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
