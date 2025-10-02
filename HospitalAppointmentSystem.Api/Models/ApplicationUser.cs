using Microsoft.AspNetCore.Identity;

namespace HospitalAppointmentSystem.Api.Models;

    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
