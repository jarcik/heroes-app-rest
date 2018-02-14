//angular
import { Component, OnInit } from '@angular/core';
//model
import {Hero} from '../model/hero';
//sluzby
import {HeroService} from '../hero.service';

@Component({
  selector: 'heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {

  //vsechny hrdinove k vypisu
  heroes: Array<Hero>;

  constructor(private heroService: HeroService) { }

  ngOnInit() {
    this.getHeroes();
  }

  //nacteni hrdinu
  private getHeroes(){
    this.heroes = this.heroService.getHeros();
  }

  //pridani hrdiny
  add(name: any) {
    if(!name || !name.value) return;
    this.heroService.addHero(name.value);
    name.value = null;
  }
 
  //smazani hrdiny
  delete(id: number) {
    this.heroService.deleteHero(id);
  }
}
