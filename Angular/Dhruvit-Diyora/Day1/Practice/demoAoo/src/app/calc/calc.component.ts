import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})
export class CalcComponent implements OnInit {

  value1: any;
  value2: any;
  answer: any;


  addition(){
    this.answer = this.value1 + this.value2;
  }

  subtraction(){
    this.answer = this.value1 - this.value2;
  }

  multiplication(){
    this.answer = this.value1 * this.value2;
  }

  division(){
    this.answer = this.value1 / this.value2;
  }
  constructor() { }

  ngOnInit(): void {
  }

}
