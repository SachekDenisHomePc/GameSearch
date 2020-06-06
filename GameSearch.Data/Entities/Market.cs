using GameSearch.Data.Interface;

namespace GameSearch.Data.Entities
{
    public class Market:IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}