import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormArray, Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-form-builder',
  templateUrl: './form-builder.component.html',
  styleUrls: ['./form-builder.component.css']
})
export class FormBuilderComponent implements OnInit {


  loginForm: FormGroup;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.loginForm = this.fb.group({
            email: [null, [Validators.required, Validators.minLength(4)]],
            password: [null, [Validators.required, Validators.maxLength(8)]]
 
        })

  }
  loginUser() {
        console.log(this.loginForm.status);
        console.log(this.loginForm.value);
    }


}
