using GameSearch.DataLayer.Entities.RatingDescription;
using GameSearch.DataLayer.Interface;

namespace GameSearch.DataLayer.Entities
{
    public class RatingField : IEntity
    {
        public Rating Rating { get; set; }
        public string Description { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int RatingCharacteristicId { get; set; }
        public RatingCharacteristic RatingCharacteristic { get; set; }
        public int Id { get; set; }
    }
}