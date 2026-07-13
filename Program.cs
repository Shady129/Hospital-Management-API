using System.Text.Json.Serialization;
using HospitalManagementAPI.Data;
using HospitalManagementAPI.Repositories;
using HospitalManagementAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<DepartmentRepository>();
            builder.Services.AddScoped<DepartmentService>();
            builder.Services.AddScoped<DoctorRepository>();
            builder.Services.AddScoped<DoctorService>();
            builder.Services.AddScoped<PatientRepository>();
            builder.Services.AddScoped<PatientService>();
            builder.Services.AddScoped<AppointmentRepository>();
            builder.Services.AddScoped<AppointmentService>();
            builder.Services.AddScoped<MedicalRecordRepository>();
            builder.Services.AddScoped<MedicalRecordService>();
            builder.Services.AddScoped<PrescriptionRepository>();
            builder.Services.AddScoped<PrescriptionService>();





            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
