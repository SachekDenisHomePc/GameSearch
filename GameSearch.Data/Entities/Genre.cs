using System.Collections.Generic;
using GameSearch.DataLayer.Interface;

namespace GameSearch.DataLayer.Entities
{
    public class Genre : IEntity
    {
        public string Name { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public IEnumerable<RatingCharacteristic> RatingCharacteristics { get; set; }
        public int Id { get; set; }
    }
}