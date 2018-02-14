using System.Collections.Generic;
using System.Threading.Tasks;
using HeroesTask.Interfaces;
using HeroesTask.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HeroesTask.Controllers
{
    [Route("api/[controller]")]
    public class HeroController : Controller
    {
        private readonly IHeroRepository _heroRepository;

        public HeroController(IHeroRepository heroRepository)
        {
            _heroRepository = heroRepository;
        }

        // GET
        [HttpGet]
        public async Task<string> Get()
        {
            var heroes = await _heroRepository.GetAllHeroes();
            return JsonConvert.SerializeObject(heroes);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
