using hrsi_api.Data;
using hrsi_api.DTO;
using hrsi_api.Migrations;
using hrsi_api.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

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

        [HttpGet]
        [Route("{id:guid}")]

        public IActionResult GetEmployeeByID(Guid id) 
        {
            var response = dbContext.employee.Find(id);

            if(response == null)
            {
                return NotFound(response);
            }

            return Ok(response);
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

        [HttpPut]
        [Route("{id:guid}")]

        public IActionResult UpdateEmployee(Guid id, updateEmployeeDTO updateEmployeeDTO)
        {
            var employee = dbContext.employee.Find(id);

            if(employee == null)
            {
                return NotFound();
            }

            employee.Name = updateEmployeeDTO.Name;
            employee.Email = updateEmployeeDTO.Email;
            employee.Phone = updateEmployeeDTO.Phone;
            employee.status = updateEmployeeDTO.status;

            dbContext.SaveChanges();

            return Ok(employee);
        }

        [HttpDelete]
        [Route("{id:guid}")]

        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = dbContext.employee.Find(id);

            if(employee == null)
            {
                return NotFound();
            }

            dbContext.employee.Remove(employee);
            dbContext.SaveChanges();

            return Ok(employee);
        }
    }
}
