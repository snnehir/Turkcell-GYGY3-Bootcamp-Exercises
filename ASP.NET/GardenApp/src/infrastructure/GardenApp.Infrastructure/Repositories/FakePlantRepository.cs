using GardenApp.Entities;
using System.Linq.Expressions;

namespace GardenApp.Infrastructure.Repositories
{
    public class FakePlantRepository : IPlantRepository
    {
        private List<Plant> _plants;
        public FakePlantRepository()
        {
            _plants = new()
            {
                new() { Id=1, Name="Rose 1", Description="Description X", Price=50, Rating=4,
                        ImageUrl = "https://pbs.twimg.com/media/Fw4x10nWYAgvq15?format=jpg&name=small"},
                new() { Id=2, Name="Lilac 1", Description="Description X", Price=55, Rating=5,
                        ImageUrl = "https://kievflower.com.ua/published/publicdata/PENTAGON/attachments/SC/products_pictures/buket-iz-sireni-violetta-471%281%29-800x800_enl.jpg"},
                new() { Id=3, Name="Tulip 1", Description="Description X", Price=60, Rating=5,
                        ImageUrl = "https://newjerseyblooms.com/cdn/shop/products/PinkParadiseTulipbouquet3_600x.jpg?v=1628108885"},
                new() { Id=4, Name="Daisy 1", Description="Description X", Price=50, Rating=3,
                        ImageUrl= "https://m.media-amazon.com/images/I/71XY2Gu3rjS.jpg"},
                new() { Id=5, Name="Rose 2", Description="Description X", Price=50, Rating=5,
                        ImageUrl = "https://pbs.twimg.com/media/Fxh8IVaWwAMhHsV?format=jpg&name=medium"},
                new() { Id=6, Name="Tulip 2", Description="Description X", Price=60, Rating=4,
                        ImageUrl = "https://cdn.shopify.com/s/files/1/0592/0007/7975/products/whitetulips.jpg?v=1641463415"},
                new() { Id=7, Name="Rose 3", Description="Description X", Price=50, Rating=4,
                        ImageUrl = "https://pbs.twimg.com/media/Fw4x10nWYAgvq15?format=jpg&name=small"},
                new() { Id=8, Name="Lilac 2", Description="Description X", Price=55, Rating=5,
                        ImageUrl = "https://kievflower.com.ua/published/publicdata/PENTAGON/attachments/SC/products_pictures/buket-iz-sireni-violetta-471%281%29-800x800_enl.jpg"},
                new() { Id=9, Name="Tulip 3", Description="Description X", Price=60, Rating=5,
                        ImageUrl = "https://cdn.shopify.com/s/files/1/0592/0007/7975/products/whitetulips.jpg?v=1641463415"},
                new() { Id=10, Name="Daisy 2", Description="Description X", Price=50, Rating=4,
                        ImageUrl= "https://m.media-amazon.com/images/I/71XY2Gu3rjS.jpg"},
                new() { Id=12, Name="Rose 4", Description="Description X", Price=50, Rating=4,
                        ImageUrl = "https://pbs.twimg.com/media/Fw4x10nWYAgvq15?format=jpg&name=small"},

            };

        }

        public Task CreateAsync(Plant entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Plant? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Plant?> GetAll()
        {
            return _plants;
        }

        public Task<IList<Plant?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Plant> GetAllWithPredicate(Expression<Func<Plant, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Plant?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plant> GetPlantsByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plant> GetPlantsByType(int plantTypeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Plant entity)
        {
            throw new NotImplementedException();
        }
    }
}
