namespace hrsi_api.DTO
{
    public class InsertEmployeeDTO
    {
        public required Guid PositionId { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string status { get; set; }
    }
}
