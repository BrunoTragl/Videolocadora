
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private formBulider: FormBuilder) { }

  ngOnInit() {
    
  }

}