import { Component, OnInit } from '@angular/core';
import { Filme } from 'src/app/models/filme.model';

@Component({
  selector: 'app-filme-alugado',
  templateUrl: './filme.alugado.component.html',
  styleUrls: ['./filme.alugado.component.css']
})
export class FilmeAlugadoComponent implements OnInit {

  public filme: Filme;

  constructor() { 
      
  }

  ngOnInit() {
    
  }

}