using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using HeroesTask.Interfaces;
using HeroesTask.Model;

namespace HeroesTask.Data
{
    public class HeroRepository : IHeroRepository
    {
        private readonly HeroContext _context = null;

        public HeroRepository(IOptions<MongoDbSettings> mongoDbSettings)
        {
            _context = new HeroContext(mongoDbSettings);
        }

        public async Task<IEnumerable<Hero>> GetAllHeroes()
        {
            try
            {
                return await _context.Heroes.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Hero> GetHero(int id)
        {
            var filter = Builders<Hero>.Filter.Eq("Id", id);
            try
            {
                return await _context.Heroes.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddHero(Hero hero)
        {
            try
            {
                await _context.Heroes.InsertOneAsync(hero);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> RemoveHero(int id)
        {

            try
            {
                DeleteResult actionResult = await _context.Heroes.DeleteOneAsync(Builders<Hero>.Filter.Eq("Id", id));
                return actionResult.IsAcknowledged && actionResult.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateHero(int id, string name)
        {
            var filter = Builders<Hero>.Filter.Eq(s => s.Id, id);
            var update = Builders<Hero>.Update.Set(s => s.Name, name);
            try
            {
                UpdateResult actionResult = await _context.Heroes.UpdateOneAsync(filter, update);
                return actionResult.IsAcknowledged && actionResult.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
