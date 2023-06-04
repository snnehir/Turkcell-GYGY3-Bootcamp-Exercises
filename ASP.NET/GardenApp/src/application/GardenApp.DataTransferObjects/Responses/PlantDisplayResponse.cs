namespace GardenApp.DataTransferObjects.Responses
{
    public class PlantDisplayResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; } = "https://picsum.photos/id/1/320/240";
        public decimal? Price { get; set; }
        public byte? Rating { get; set; }
    }
}
