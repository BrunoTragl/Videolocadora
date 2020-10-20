import { Component, OnInit } from '@angular/core';
import { Filme } from 'src/app/models/filme.model';

@Component({
  selector: 'app-filme-buscar',
  templateUrl: './filme.buscar.component.html',
  styleUrls: ['./filme.buscar.component.css']
})
export class FilmeBuscarComponent implements OnInit {

  public filme: Filme;

  constructor() { 
      
  }

  ngOnInit() {
    
  }

}