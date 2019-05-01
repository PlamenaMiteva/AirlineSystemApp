using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data
{
    class Client: IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DocumentType DocumentType { get; set; }

        [Required]
        public string DocumentNumber { get; set; }
    }
}
