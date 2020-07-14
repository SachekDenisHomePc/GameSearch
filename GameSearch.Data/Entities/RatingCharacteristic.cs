using System.Collections.Generic;
using GameSearch.DataLayer.Interface;

namespace GameSearch.DataLayer.Entities
{
    public class RatingCharacteristic : IEntity
    {
        public string Name { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public IEnumerable<RatingField> RatingFields { get; set; }
        public int Id { get; set; }
    }
}