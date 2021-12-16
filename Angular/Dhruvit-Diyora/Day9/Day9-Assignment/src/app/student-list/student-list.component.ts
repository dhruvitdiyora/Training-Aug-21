import { Component, OnInit } from '@angular/core';
import { IStudent } from '../IStudent';
import { StudentService } from '../service/student.service';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {

  studentList: IStudent[] = [];
  constructor(private studentService: StudentService) { }

  ngOnInit(): void {
  }
  get() {
    this.studentList = this.studentService.getStudents();
  }
  delete(i: number) {
    this.studentService.deleteStudent(i);
  }
  edit(i: number) {
    this.studentService.editStudent(i);
  }

}
