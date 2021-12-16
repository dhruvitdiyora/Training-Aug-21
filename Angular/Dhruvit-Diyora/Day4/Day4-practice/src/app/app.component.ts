import { Component } from '@angular/core';
import { FormGroup, FormControl, FormArray, Validators } from '@angular/forms';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Day4-practice';
  loginForm: FormGroup;
 
    ngOnInit() {
 
        this.loginForm = new FormGroup({
            email: new FormControl(null, [Validators.required, Validators.minLength(4)]),
            password: new FormControl(null, [Validators.required, Validators.maxLength(8)])
        });
    }
    loginUser() {
        console.log(this.loginForm.status);
        console.log(this.loginForm.value);
    }
}
