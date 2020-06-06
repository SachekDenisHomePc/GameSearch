using GameSearch.Data.Interface;

namespace GameSearch.Data.Entities
{
    public class Developer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}