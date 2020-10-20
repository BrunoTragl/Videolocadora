import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from './services/authentication.service'
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
  title = 'Videolocadora';

  constructor(private authentication: AuthenticationService,  private router: Router) { }

  ngOnInit(): void {
    this.authentication.currentUser.subscribe(user => {
      if(user == undefined){
        this.router.navigate(['/login']);
      }
    })
  }
  
}
