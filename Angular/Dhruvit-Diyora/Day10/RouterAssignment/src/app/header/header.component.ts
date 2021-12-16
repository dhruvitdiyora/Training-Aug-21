import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  message: string;
  constructor(public authService: AuthService) {
    this.message = '';
  }

  ngOnInit(): void {

  }
  login(username: string, password: string): boolean {
    this.message = '';
    if (!this.authService.login(username, password)) {
      this.message = 'Incorrect credentials.';
      setTimeout(() => {
        this.set();
      }, 2500);
    }
    return false;
  }

  logout(): boolean {
    this.authService.logout();
    return false;
  }
  set() {
    this.message = '';
  }

}
