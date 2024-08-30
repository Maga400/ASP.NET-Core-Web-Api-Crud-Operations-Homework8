﻿using ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Entities;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}
