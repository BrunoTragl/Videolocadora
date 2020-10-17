import { Component, OnInit } from '@angular/core';
import { Filme } from 'src/app/models/filme.model';

@Component({
  selector: 'app-filme',
  templateUrl: './filme.component.html',
  styleUrls: ['./filme.component.css']
})
export class FilmeComponent implements OnInit {

  public filme: Filme;

  constructor() { 
      
  }

  ngOnInit() {
    this.filme.descricao = "asdfkjhaskdfh";
  }

}