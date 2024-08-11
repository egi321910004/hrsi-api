namespace hrsi_api.DTO
{
    public class InsertPositionDTO
    {
        public required string name_position { get; set; }
        public required string salary { get; set; }
        public required string division { get; set; }
        public required string department { get; set; }
        public required string status { get; set; }
    }
}
