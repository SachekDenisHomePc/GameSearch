using GameSearch.Data.Entities.RatingDescription;
using GameSearch.Data.Interface;

namespace GameSearch.Data.Entities
{
    public class RatingField : IEntity
    {
        public int Id { get; set; }
        public Rating Rating { get; set; }
        public string Description { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int RatingCharacteristicId { get; set; }
        public RatingCharacteristic RatingCharacteristic { get; set; }
    }
}