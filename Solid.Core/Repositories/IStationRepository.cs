using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IStationRepository
    {
        List<Station> GetList();
        Station GetById(int id);
        void Update(int id, Station station);
        void Add(Station station);
        void Remove(int id);
    }
}
