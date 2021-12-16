import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  name: any;
  address: any;
  pan: any;
  answer: any;

  display(){
    this.answer = `Name is: ${this.name}, Address is: ${this.address}, PAN Number is: ${this.pan}`;
  }
  constructor() { }

  ngOnInit(): void {
  }

}
