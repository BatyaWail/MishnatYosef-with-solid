using Solid.Core.Models;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    internal class StationService : IStationServices
    {
        private readonly IStationRepository _stationRepository;
        public StationService(IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
        }
        public void AddItem(Station station)
        {
            _stationRepository.Add(station);
        }

        public Station GetByIdItem(int id)
        {
            return _stationRepository.GetById(id);
        }

        public List<Station> GetListItems()
        {
            return _stationRepository.GetList();
        }

        public void RemoveItem(int id)
        {
            _stationRepository.Remove(id);
        }

        public void UpdateItem(int id, Station station)
        {
            _stationRepository.Update(id, station);
        }
    }
}
