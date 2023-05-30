namespace Gardens.Entitiy
{
    public class Garden: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string GardenType { get; set; } = String.Empty;
        public string? Detail { get; set; }

        // Navigation Property
        public ICollection<GardenOwner> Owners { get; set; } = new HashSet<GardenOwner>();
        public ICollection<GardenNote> GardenNotes { get; set; } = new HashSet<GardenNote>();
    }
}