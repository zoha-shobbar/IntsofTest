﻿using System.ComponentModel.DataAnnotations;

namespace Intsoft.Exam.Domain.Entities
{
    public class User : BaseEntitiy
    {
        public string? FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string NationalCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
