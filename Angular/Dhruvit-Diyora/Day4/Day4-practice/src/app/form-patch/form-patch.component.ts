import { Component, OnInit } from '@angular/core';
import { FormGroup, FormArray, Validators, FormBuilder } from '@angular/forms';
import { Observable } from 'rxjs';

import { Team } from './team';
import { Employee } from './employee';

import {TeamsService} from './teamsSer';
@Component({
  selector: 'app-form-patch',
  templateUrl: './form-patch.component.html',
  styleUrls: ['./form-patch.component.css']
})
export class FormPatchComponent implements OnInit {
  teamForm: FormGroup;
	isValidFormSubmitted:boolean ;
	allSkills: Observable<any[]>;


  constructor(private formBuilder: FormBuilder,private teamMngService: TeamsService) {
	}

  ngOnInit(): void {
    this.allSkills = this.teamMngService.getSkills();

		this.teamForm = this.formBuilder.group({
			teamName: ['', Validators.required],
			employees: this.formBuilder.array([
				this.formBuilder.group(new Employee()),
				this.formBuilder.group(new Employee())
			])
		});	
  }
  get teamName() {
		return this.teamForm.get('teamName');
	}	
	get employees(): FormArray {
		return this.teamForm.get('employees') as FormArray;
	}
	addEmployee() {
		let fg = this.formBuilder.group(new Employee());
		this.employees.push(fg);
	}
	deleteEmployee(idx: number) {
		this.employees.removeAt(idx);
	}
	onFormSubmit() {
		this.isValidFormSubmitted = false;
		if (this.teamForm.invalid) {
			return;
		}
		this.isValidFormSubmitted = true;		
		let team: Team = this.teamForm.value;
		this.teamMngService.saveTeam(team);
		this.teamForm.reset();
	}
	patchEmployeeValues() {
		this.employees.patchValue([
			{ empId: "111", empName: "Mohan"},
			{ empId: "112", skill: "Angular"}
		]);
	}
	setEmployeeValues() {
		this.employees.setValue([
			{ empId: "111", empName: "Mohan", skill: "Java"},
			{ empId: "112", empName: "Krishna", skill: "Angular"}	
		]);

        /**
		let emp1 = new Employee();
		emp1.empId = "111";
		emp1.empName = "Mohan";
		emp1.skill = "Java";

		let emp2 = new Employee();
		emp2.empId = "112";
		emp2.empName = "Krishna";
		emp2.skill = "Angular";		

		this.employees.setValue([emp1, emp2]); */		
	}
	resetTeamForm() {
		this.teamForm.reset();
	}


}
