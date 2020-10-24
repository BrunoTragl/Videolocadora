import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from './services/authentication.service'
import { Router } from '@angular/router';
import { ResizedEvent } from 'angular-resize-event';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
  title = 'Videolocadora';
  position = 'fixed';
  constructor(private authentication: AuthenticationService,  private router: Router) { }

  ngOnInit(): void {
    this.authentication.currentUser.subscribe(user => {
      if(user == undefined){
        this.router.navigate(['/login']);
      }
    })
  }

  onResized(event: ResizedEvent) {
    if(event.newHeight < window.innerHeight) {
      this.position = 'fixed';
    }
    else {
      this.position = 'bottom';
    }
  }
}
