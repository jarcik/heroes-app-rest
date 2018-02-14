//angular
import { Component, OnInit } from '@angular/core';
//model
import {Hero} from '../model/hero';
//sluzby
import {HeroService} from '../hero.service';

@Component({
  selector: 'dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  //top 5 hrdinu
  topHeroes: Array<Hero>;

  constructor(private heroService: HeroService) { }

  ngOnInit() {
    this.getTopHeroes();
  }

  //prevzeti top 5 hrdinu
  private getTopHeroes() {
    this.topHeroes = this.heroService.getHeros().slice(0, 5);
  }

}
