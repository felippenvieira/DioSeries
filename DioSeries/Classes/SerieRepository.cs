using System.Collections.Generic;
using DioSeries.Interfaces;

namespace DioSeries
{
    public class SerieRepository : IRepository<Serie>
    {
        private readonly List<Serie> serieList = new List<Serie>();
        public void Update(int id, Serie entity)
        {
            serieList[id] = entity;
        }

        public void Delete(int id)
        {
            serieList[id].DeleteSerie();
        }

        public void Insert(Serie entity)
        {
            serieList.Add(entity);
        }

        public List<Serie> SeriesList()
        {
            return serieList;
        }

        public int NextId()
        {
            return serieList.Count;
        }

        public Serie ReturnById(int id)
        {
            return serieList[id];
        }
    }
}
