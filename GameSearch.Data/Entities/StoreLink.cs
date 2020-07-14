using GameSearch.DataLayer.Interface;

namespace GameSearch.DataLayer.Entities
{
    public class StoreLink : IEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}