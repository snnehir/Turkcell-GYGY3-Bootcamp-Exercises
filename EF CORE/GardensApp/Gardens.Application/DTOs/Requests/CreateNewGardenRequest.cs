namespace Gardens.Application.DTOs.Requests
{
    public class CreateNewGardenRequest
    {
        public string Name { get; set; } = String.Empty;
        public string GardenType { get; set; } = String.Empty;
        public string? Detail { get; set; }
    }
}
