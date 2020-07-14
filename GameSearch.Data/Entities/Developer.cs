using System.Collections.Generic;
using GameSearch.DataLayer.Interface;

namespace GameSearch.DataLayer.Entities
{
    public class Developer : IEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public IEnumerable<Game> Games { get; set; }
    }
}