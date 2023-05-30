namespace Gardens.Entitiy
{
    public class Owner: IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Bio { get; set; }

        // Navigation Property
        public ICollection<GardenOwner> Gardens { get; set; } = new HashSet<GardenOwner>();
    }
}
