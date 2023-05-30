using Gardens.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardens.Data.Repositories
{
    public interface IGardenRepository: IRepository<Garden>
    {
        // interface seggregation principle
        Task<IList<Garden>> SearchGardenByName(string name);
    }
}
