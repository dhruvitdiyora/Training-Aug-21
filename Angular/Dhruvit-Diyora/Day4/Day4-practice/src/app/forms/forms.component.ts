import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormArray,Validators,FormBuilder } from '@angular/forms';
//import Validation from './utils/validation';
@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.css']
})
export class FormsComponent implements OnInit {
  loginForm: FormGroup;

  emaill = new FormControl('');
  constructor(private fb: FormBuilder) {
 }


  logForm = new FormGroup({
    email: new FormControl(' '),
    password: new FormControl(' ')
  });

  ngOnInit() {

      this.loginForm = new FormGroup({
          email1: new FormControl(null, [Validators.required, Validators.minLength(4)]),
          password1: new FormControl(null, [Validators.required, Validators.maxLength(8)])
      });
  }
  loginUser() {
      console.log(this.loginForm.status);
      console.log(this.loginForm.value);
  }


}
