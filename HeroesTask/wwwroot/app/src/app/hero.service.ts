//angular
import {Injectable} from '@angular/core';
//model
import {Hero} from './model/hero';

/* sluzba spravy hrdinu */
@Injectable()
export class HeroService {

    /* seznam hrdinu */
    getHeros(): Array<Hero> {
        return this.heroes;
    }

    /* pridani hrdiny */
    addHero(name: string): Hero {
        let index = this.heroes.length > 0 ? this.heroes[this.heroes.length - 1].id + 1 : 0;
        let hero: Hero = {id:index, name: name};
        this.heroes.push(hero);
        return hero;
    }

    /* odebrani hrdiny */
    deleteHero(id: number) {
        let index = this.heroes.findIndex((s) => s.id == id);
        if(index > -1) {
            this.heroes.splice(index, 1);
        }
    }

    //detail jednoho hrdiny
    getHero(id: number): Hero {
        let index = this.heroes.findIndex((s) => s.id == id);
        if(index > -1)
            return this.heroes[index];
        return null;
    }

    //aktualizace hrdiny
    updateHero(hero: Hero) {
        let index = this.heroes.findIndex((s) => s.id == hero.id);
        if(index > -1) {
            this.heroes[index] = hero;
        }
    }

    private heroes: Array<Hero> = [
        {id:0, name: 'Elon Musk'},
        {id:1, name: 'Bumblebee'},
        {id:2, name: 'Black Widow'},
        {id:3, name: 'Arrow'},
        {id:4, name: 'Iron Man'},
        {id:5, name: 'Wonder Woman'},
        {id:6, name: 'Jack O\'neill'},
        {id:7, name: 'Samantha Carter'},
        {id:8, name: 'Optimus Prime'}
    ];
}