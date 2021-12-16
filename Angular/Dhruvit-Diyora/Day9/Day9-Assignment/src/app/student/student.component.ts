import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { IStudent } from '../IStudent'
import { StudentService } from '../service/student.service';
@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {
  studentDetails: Array<IStudent> = [];
  constructor(private fb: FormBuilder, private studentService: StudentService) { }

  ngOnInit(): void {
  }
  get EmergancyContactList() {
    return this.admissionForm.get("EmergancyContactList") as FormArray;
  }
  get References() {
    return this.admissionForm.get("References") as FormArray;
  }

  admissionForm = this.fb.group({
    FirstName: [null, Validators.required],
    MiddleName: [null, Validators.required],
    LastName: [null, Validators.required],
    Dob: [null, Validators.required],
    PlaceOfBirth: [null, Validators.required],
    FirstLanguage: [null, Validators.required],
    Address: this.fb.group({
      City: [null, [Validators.required, Validators.minLength(3)]],
      State: [null, [Validators.required, Validators.minLength(3)]],
      Country: [null, [Validators.required, Validators.minLength(3)]],
      Pin: [null, [Validators.required, Validators.minLength(6)]]
    }),
    Father: this.fb.group({
      FFirstName: [null, Validators.required],
      FMiddleName: [null, Validators.required],
      FLastName: [null, Validators.required],
      FEmail: [null, [Validators.required, Validators.email]],
      FQualification: [null, Validators.required],
      FProfession: [null, Validators.required],
      FDesignation: [null, Validators.required],
      FPhone: [null, Validators.required]
    }),
    Mother: this.fb.group({
      MFirstName: [null, Validators.required],
      MMiddleName: [null, Validators.required],
      MLastName: [null, Validators.required],
      MEmail: [null, [Validators.required, Validators.email]],
      MQualification: [null, Validators.required],
      MProfession: [null, Validators.required],
      MDesignation: [null, Validators.required],
      MPhone: [null, Validators.required]
    }),
    EmergancyContactList: this.fb.array([this.createContactFormGroup()], [Validators.required, Validators.maxLength(5)]),
    References: this.fb.array([this.createReferenceFormGroup()], [Validators.required, Validators.maxLength(5)]),
  });

  onSubmit() {

    this.studentDetails.push(this.admissionForm.value);
    console.log(this.studentDetails);

    this.studentService.addStudent(this.admissionForm.value);

    this.admissionForm.reset();

  }
  createContactFormGroup() {
    return this.fb.group({
      Relation: [null, [Validators.required]],
      Number: [null, [Validators.required, Validators.min(9)]],
    })
  }
  createReferenceFormGroup() {
    return this.fb.group({
      ReferenceThrough: [null, [Validators.required]],
      Address: [null, [Validators.required]],
      RefsNumber: [null, [Validators.required, Validators.min(9)]],
    })
  }
  addContact() {
    this.EmergancyContactList.push(this.createContactFormGroup());
  }
  deleteContact(idx: number) {
    this.EmergancyContactList.removeAt(idx);
  }
  addReferences() {
    this.References.push(this.createContactFormGroup());
  }
  deleteReferences(idx: number) {
    this.References.removeAt(idx);
  }

}
