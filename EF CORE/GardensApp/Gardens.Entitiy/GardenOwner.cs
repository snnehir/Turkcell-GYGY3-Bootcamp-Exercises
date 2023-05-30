namespace Gardens.Entitiy
{
    public class GardenOwner
    {
        public int GardenId { get; set; }
        public Garden Garden { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public string Role { get; set; }
    }
}
