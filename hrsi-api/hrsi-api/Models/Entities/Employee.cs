using System.Security.Cryptography.X509Certificates;

namespace hrsi_api.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public Guid PositionId { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string status { get; set; }
    }
}
