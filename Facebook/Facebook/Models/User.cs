using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facebook.WebApi.Models
{
    public class User
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime? Birthday { get; set; }
        //dateTime moze i da e bez ? togash defaultna kje ni ja vrati 01 01 00000 ! :D
        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public Gender? Gender { get; set; }

    }

 

 
}
