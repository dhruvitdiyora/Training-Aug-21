import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-circle',
  templateUrl: './circle.component.html',
  styleUrls: ['./circle.component.css']
})
export class CircleComponent implements OnInit {

  pi: number = 3.14;
  radius: any;
  answer: any;

  circleArea(){
    this.answer = this.pi * (this.radius * this.radius);
  }
  
  constructor() { }

  ngOnInit(): void {
  }

}
