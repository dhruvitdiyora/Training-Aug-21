import { Component, OnInit } from '@angular/core';
import { IStudent } from './studentInterface';
@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  
  StudentList : Array<IStudent> = 
    [
      {
        "Id": 1,
        "Name": "Dhruvit",
        "Age": 20,
        "Average": 70,
        "Grade": "B2",
        "Active": true
      },
      {
        "Id": 2,
        "Name": "Piyush",
        "Age": 21,
        "Average": 75,
        "Grade": "B1",
        "Active": false
      },
      {
        "Id": 3,
        "Name": "Shubh",
        "Age": 22,
        "Average": 80,
        "Grade": "A2",
        "Active": false
      },
      {
        "Id": 4,
        "Name": "Hemanshu",
        "Age": 23,
        "Average": 85,
        "Grade": "A2",
        "Active": true
      },
      {
        "Id": 5,
        "Name": "Niraj",
        "Age": 24,
        "Average": 90,
        "Grade": "A1",
        "Active": true
      },
      {
        "Id": 6,
        "Name": "Dhruvit",
        "Age": 20,
        "Average": 70,
        "Grade": "A2",
        "Active": false
      },
      {
        "Id": 7,
        "Name": "Piyush",
        "Age": 21,
        "Average": 85,
        "Grade": "A1",
        "Active": true
      },
      {
        "Id": 8,
        "Name": "Shubh",
        "Age": 22,
        "Average": 90,
        "Grade": "A1",
        "Active": true
      },
      {
        "Id": 9,
        "Name": "Hemanshu",
        "Age": 23,
        "Average": 75,
        "Grade": "B1",
        "Active": true
      },
      {
        "Id": 10,
        "Name": "Niraj",
        "Age": 24,
        "Average": 70,
        "Grade": "A1",
        "Active": false
      }
      
]
  constructor() { }

  ngOnInit(): void {
  }

}
