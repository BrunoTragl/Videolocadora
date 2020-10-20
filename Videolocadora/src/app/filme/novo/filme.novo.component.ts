import { Component, OnInit } from '@angular/core';
import { Filme } from 'src/app/models/filme.model';

@Component({
  selector: 'app-filme-novo',
  templateUrl: './filme.novo.component.html',
  styleUrls: ['./filme.novo.component.css']
})
export class FilmeNovoComponent implements OnInit {

  public filme: Filme;

  constructor() { 
      
  }

  ngOnInit() {
    
  }

}