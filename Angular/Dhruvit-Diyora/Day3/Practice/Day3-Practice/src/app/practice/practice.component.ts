import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-practice',
  templateUrl: './practice.component.html',
  styleUrls: ['./practice.component.css']
})
export class PracticeComponent implements OnInit {


  something: string = '';
  choice: boolean = false;
    ngStyle(){
    return{ 'font-size.px':80,
            'font-style': 'italic,bold',
            'color': 'red',
            'background-color': 'blue'
          }
  }

    
  ngClass(){
    return{
      'btn':true,
      'btn-danger':true,
      'btn-lg': true
    }
  }


  ngIf(){
    if(this.choice == true){
      this.choice = false;
    }
    else{
      this.choice = true;
    }
  }
  ids=[1,2,3,4,5,6,7,8]

  employees = [
    {
      Id: 1,
      Name: "Dhruvit",
      City: "surat"
      
    },
    {
      Id: 2,
      Name: "piyush",
      City: "ahmedabad"
      
    },
    {
      Id: 3,
      Name: "shubh",
      City: "rajkot"
      
    },
    {
      Id: 4,
      Name: "niraj",
      City: "bombay"
      
    },
    {
      Id: 5,
      Name: "hemanshu",
      City: "vadodara"
      
    }

  ];

  constructor() { }

  ngOnInit(): void {
  }

}
