using Facebook.WebApi.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facebook.WebApi.View
{
    public class UpdateUserViewModel
    {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }

            public string Password { get; set; }

            public DateTime Birthday { get; set; }

            [JsonConverter(typeof(StringEnumConverter))]
            public Gender Gender { get; set; }

        
    }
}
