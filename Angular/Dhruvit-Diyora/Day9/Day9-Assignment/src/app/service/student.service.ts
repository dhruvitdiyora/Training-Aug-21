import { Injectable } from '@angular/core';
import { IStudent } from '../IStudent';
import { LoggerService } from './logger.service';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  students: IStudent[] = [];

  constructor(private loggerService: LoggerService) { }
  public getStudents() {
    this.loggerService.log('getStudents called');

    this.students = [
      {
        "FirstName": "Dhruvit",
        "MiddleName": "rajeshbhai",
        "LastName": "Diyora",
        "Dob": "2021-12-09",
        "PlaceOfBirth": "gadhada",
        "FirstLanguage": "gujarati",
        "Address": {
          "City": "Surat",
          "State": "Gujarat",
          "Country": "India",
          "Pin": "395004"
        },
        "Father": {
          "FFirstName": "Dhruvit",
          "FMiddleName": "rajeshbhai",
          "FLastName": "Diyora",
          "FEmail": "dhruvit.d9688@gmail.com",
          "FQualification": "dfdsv",
          "FProfession": "diamond",
          "FDesignation": "avfv",
          "FPhone": "9157049688"
        },
        "Mother": {
          "MFirstName": "Dhruvit",
          "MMiddleName": "rajeshbhai",
          "MLastName": "Diyora",
          "MEmail": "dhruvit.d9688@gmail.com",
          "MQualification": "dfdsv",
          "MProfession": "diamond",
          "MDesignation": "avfv",
          "MPhone": "9157049688"
        },
        "EmergancyContactList": [
          {
            "Relation": "csdv",
            "Number": "9875642456"
          },
          {
            "Relation": "sfbdfb",
            "Number": "9875642456"
          },
          {
            "Relation": "cfbdfbdsdv",
            "Number": "9875642456"
          }
        ],
        "References": [
          {
            "ReferenceThrough": "efewfw",
            "Address": "208 akshardham soc.",
            "RefsNumber": "9875642456"
          },
          {
            "ReferenceThrough": "svf",
            "Address": "208 akshardham soc.",
            "RefsNumber": "9875642456"
          },
          {
            "ReferenceThrough": "efewfw",
            "Address": "208 akshardham soc.",
            "RefsNumber": "9875642456"
          }
        ]
      },
      {
        "FirstName": "Dhruvit",
        "MiddleName": "rajeshbhai",
        "LastName": "Diyora",
        "Dob": "2021-12-09",
        "PlaceOfBirth": "gadhada",
        "FirstLanguage": "gujarati",
        "Address": {
          "City": "Surat",
          "State": "Gujarat",
          "Country": "India",
          "Pin": "395004"
        },
        "Father": {
          "FFirstName": "Dhruvit",
          "FMiddleName": "rajeshbhai",
          "FLastName": "Diyora",
          "FEmail": "dhruvit.d9688@gmail.com",
          "FQualification": "dfdsv",
          "FProfession": "diamond",
          "FDesignation": "avfv",
          "FPhone": "9157049688"
        },
        "Mother": {
          "MFirstName": "Dhruvit",
          "MMiddleName": "rajeshbhai",
          "MLastName": "Diyora",
          "MEmail": "dhruvit.d9688@gmail.com",
          "MQualification": "dfdsv",
          "MProfession": "diamond",
          "MDesignation": "avfv",
          "MPhone": "9157049688"
        },
        "EmergancyContactList": [
          {
            "Relation": "csdv",
            "Number": "9875642456"
          },
          {
            "Relation": "sfbdfb",
            "Number": "9875642456"
          },
          {
            "Relation": "cfbdfbdsdv",
            "Number": "9875642456"
          }
        ],
        "References": [
          {
            "ReferenceThrough": "efewfw",
            "Address": "208 akshardham soc.",
            "RefsNumber": "9875642456"
          },
          {
            "ReferenceThrough": "svf",
            "Address": "208 akshardham soc.",
            "RefsNumber": "9875642456"
          },
          {
            "ReferenceThrough": "efewfw",
            "Address": "208 akshardham soc.",
            "RefsNumber": "9875642456"
          }
        ]
      }

    ];

    this.loggerService.log(this.students);
    return this.students;
  }
  public addStudent(s: IStudent) {
    this.students.push(s);
    this.loggerService.log('addStudent called');

  }
  public deleteStudent(i: number) {
    this.students.splice(i, 1);
    this.loggerService.log('deleteStudent called');

  }
  public editStudent(i: number) {

    this.loggerService.log('editStudent called');

  }
}
