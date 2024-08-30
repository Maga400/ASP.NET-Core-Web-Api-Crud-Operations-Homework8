﻿using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Surname { get; set; }
    }
}
