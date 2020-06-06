using System;
using GameSearch.Data.Interface;

namespace GameSearch.Data.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }
    }
}