using GameSearch.Data.Interface;

namespace GameSearch.Data.Entities
{
    public class RatingCharacteristic:IEntity
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}