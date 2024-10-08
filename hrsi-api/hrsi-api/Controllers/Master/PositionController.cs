﻿using hrsi_api.Data;
using hrsi_api.DTO;
using hrsi_api.Migrations;
using hrsi_api.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace hrsi_api.Controllers.Master
{
    [Route("api/master/[controller]")]
    public class PositionController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public PositionController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllPosition()
        {
            var allPosition = dbContext.position.ToList();

            return Ok(allPosition);
        }

        [HttpPost]

        public IActionResult InsertPosition(InsertPositionDTO InsertPositionDTO)
        {
            if(InsertPositionDTO == null)
            {
                return BadRequest("Position Data is Null");
            }

            var positionData = new Position()
            {
              name_position = InsertPositionDTO.name_position,
              salary = InsertPositionDTO.salary,
              department = InsertPositionDTO.department,
              division = InsertPositionDTO.division,
              status = InsertPositionDTO.status,
              Employees = new List<Employee>()


            };

            dbContext.position.Add(positionData);
            dbContext.SaveChanges();

            return Ok(positionData);
        }

        [HttpPut]
        [Route("{id:guid}")]

        public IActionResult UpdatePosition(Guid id ,updatePositionDTO updatePositionDTO)
        {
            var Position = dbContext.position.Find(id);

            if(Position == null)
            {
                return NotFound();
            }

            if(updatePositionDTO == null)
            {
                return BadRequest();
            }

            Position.name_position = updatePositionDTO.name_position;
            Position.division = updatePositionDTO.division;
            Position.department = updatePositionDTO.department;
            Position.salary = updatePositionDTO.salary;
            Position.status = updatePositionDTO.status;

            dbContext.SaveChanges();

            return Ok(Position);
        }

        [HttpDelete]
        [Route("{id:guid}")]

        public IActionResult DeletePosition(Guid id)
        {
            var Position = dbContext.position.Find(id);

            if (Position == null)
            {
                return NotFound();
            }

            dbContext.position.Remove(Position);
            dbContext.SaveChanges();

            return Ok(Position);
        }
    }
}
