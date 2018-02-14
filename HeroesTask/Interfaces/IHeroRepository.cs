using System.Collections.Generic;
using System.Threading.Tasks;
using HeroesTask.Model;

namespace HeroesTask.Interfaces
{
    public interface IHeroRepository
    {
        /// <summary>
        /// Dotaz na vsechny hrdiny
        /// </summary>
        Task<IEnumerable<Hero>> GetAllHeroes();
        /// <summary>
        /// Dotaz na jednoho hrdinu
        /// </summary>
        /// <param name="id">ID pozadovaneho hrdiny</param>
        Task<Hero> GetHero(int id);
        /// <summary>
        /// Pridani noveho hrdiny
        /// </summary>
        /// <param name="hero">pridavany hrdina</param>
        Task AddHero(Hero hero);
        /// <summary>
        /// Odstraneni hriny
        /// </summary>
        /// <param name="id">Id odstranovaneho hrdiny</param>
        Task<bool> RemoveHero(int id);
        /// <summary>
        /// Aktualizace hrdiny
        /// </summary>
        /// <param name="id">Id aktualizovaneho hrdiny</param>
        /// <param name="name">aktualizace</param>
        Task<bool> UpdateHero(int id, string name);
    }
}
