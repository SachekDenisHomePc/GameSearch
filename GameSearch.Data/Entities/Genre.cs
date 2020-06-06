using GameSearch.Data.Interface;

namespace GameSearch.Data.Entities
{
    public class Genre:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}