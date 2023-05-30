namespace Gardens.Entitiy
{
    public class GardenNote: IEntity
    {
        public int Id { get; set; }
        public string Note { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        // Navigation Property
        public Garden? Garden { get; set; }
        public int? GardenId { get; set; }
    }
}
