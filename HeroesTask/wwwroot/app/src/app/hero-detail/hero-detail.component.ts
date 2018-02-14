//angular
import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from '@angular/router';
//model
import {Hero} from '../model/hero';
//sluzby
import {HeroService} from '../hero.service';

@Component({
  selector: 'hero-detail',
  templateUrl: './hero-detail.component.html',
  styleUrls: ['./hero-detail.component.css']
})
export class HeroDetailComponent implements OnInit {

  //aktualne zobrazeny hrdina
  hero: Hero;

  constructor(private activatedRoute: ActivatedRoute,
  private heroService: HeroService) { }

  ngOnInit() {
    this.getHero();
  }

  private getHero() {
    let id = +this.activatedRoute.snapshot.paramMap.get('id');
    this.hero = this.heroService.getHero(id);
  }

  back() {
    window.history.back();
  }

  //editace jmena hrdiny
  updateName() {
    this.heroService.updateHero(this.hero);
  }
}
