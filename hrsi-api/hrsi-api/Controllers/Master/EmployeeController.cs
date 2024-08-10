﻿using hrsi_api.Data;
using hrsi_api.DTO;
using hrsi_api.Migrations;
using hrsi_api.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace hrsi_api.Controllers.Master
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            var allEmployee = dbContext.employee.ToList();

            return Ok(allEmployee);
        }

        [HttpPost]
        public IActionResult InsertEmployee([FromBody] InsertEmployeeDTO addEmployeeDto)
        {
            if (addEmployeeDto == null)
            {
                return BadRequest("Employee data is null");
            }

            var employeeData = new Employee()
            {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                status = addEmployeeDto.status 
            };

            dbContext.employee.Add(employeeData);
            dbContext.SaveChanges();

            return Ok(employeeData);
        }
    }
}
