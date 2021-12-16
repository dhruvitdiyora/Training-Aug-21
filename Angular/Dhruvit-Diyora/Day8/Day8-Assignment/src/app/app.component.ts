import { FormGroup, FormControl, FormArray } from '@angular/forms';
import { Component } from '@angular/core';
import { IStudent } from './IStudent';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Day8-Assignment';

  data: Array<IStudent> = [];
  eventHandler(event: any) {
    this.data = event;

  }
}
