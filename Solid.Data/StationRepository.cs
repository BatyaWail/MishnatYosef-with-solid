using Solid.Core.Models;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class StationRepository: IStationRepository
    {
        private readonly DataContext _dataContext;
        public StationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(Station station)
        {
            _dataContext.stations.Add(station);
        }

        public Station GetById(int id)
        {
            return _dataContext.stations.Find(x => x.Id == id);

        }

        public List<Station> GetList()
        {
            return _dataContext.stations;
        }

        public void Remove(int id)
        {
            _dataContext.stations.Remove(_dataContext.stations.Find(x => x.Id == id));
        }

        public void Update(int id, Station station)
        {
            int x = _dataContext.stations.FindIndex(x => x.Id == id);
            _dataContext.stations[x] = station;
        }
    }
}
