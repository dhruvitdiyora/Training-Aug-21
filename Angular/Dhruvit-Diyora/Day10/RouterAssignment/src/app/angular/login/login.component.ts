import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  username: any;
  password: any;
  answer: any;

  validate() {
    if (this.username == "admin" && this.password == "admin") {
      this.answer = "User Authorized";
    }
    else
      this.answer = "Wrong Credentials";
  }
  constructor() { }

  ngOnInit(): void {
  }

}
