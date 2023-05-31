namespace Gardens.Application.DTOs.Responses
{
    public class GardenListResponse
    {
        public string Name { get; set; } = String.Empty;
        public string GardenType { get; set; } = String.Empty;
        public string? Detail { get; set; }
    }
}
