﻿using ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Entities;

namespace ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Services.Abstracts
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task UpdateAsync(Customer? customer);
        Task AddAsync(Customer? customer);
        Task DeleteAsync(int id);
    }
}
