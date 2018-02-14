using MongoDB.Bson.Serialization.Attributes;

namespace HeroesTask.Model
{
    public class Hero
    {
        /// <summary>
        /// Id hrdiny
        /// </summary>
        [BsonId]
        public int Id { get; set; }
        /// <summary>
        /// Jmeno
        /// </summary>
        [BsonElement("Name")]
        public string Name { get; set; }
    }
}
