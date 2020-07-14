using System;
using System.Collections.Generic;
using GameSearch.DataLayer.Interface;

namespace GameSearch.DataLayer.Entities
{
    public class Game : IEntity
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }
        public IEnumerable<StoreLink> StoreLinks { get; set; }
        public IEnumerable<RatingField> RatingFields { get; set; }
        public int Id { get; set; }
    }
}