using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineSystem.Data.EntityModels
{
    public class Client: IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public Guid PassengerId { get; set; }

        public virtual Passenger Passenger { get; set; }
    }
}
