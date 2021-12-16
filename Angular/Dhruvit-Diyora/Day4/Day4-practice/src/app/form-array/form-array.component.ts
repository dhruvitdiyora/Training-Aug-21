import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl,FormArray, FormBuilder,Validators } from '@angular/forms'

@Component({
  selector: 'app-form-array',
  templateUrl: './form-array.component.html',
  styleUrls: ['./form-array.component.css']
})
export class FormArrayComponent implements OnInit {


    orderForm: FormGroup;
  items: FormArray;


  // skillsForm: FormGroup;
  //profileForm: FormGroup;
  skillsForm: FormGroup;
  
  constructor(private formBuilder:FormBuilder) { }



  ngOnInit(): void {
    this.orderForm = this.formBuilder.group({
      customerName: '',
      email: '',
      items: this.formBuilder.array([ this.createItem() ])
    });
    

      this.skillsForm = this.formBuilder.group({
      name: '',
      skills: this.formBuilder.array([]) ,
    });
  // }
  //   get skills() : FormArray {
  //   return this.skillsForm.get("skills") as FormArray
  }
  createItem(): FormGroup {
    return this.formBuilder.group({
      name: '',
      description: '',
      price: ''
    });
  }
    addItem(): void {
    this.items = this.orderForm.get('items') as FormArray;
    this.items.push(this.createItem());
  }
get userFormGroups () {
  return this.orderForm.get('items') as FormArray
}
  
  
  get skills() : FormArray {
    return this.skillsForm.get("skills") as FormArray
  }
 
  newSkill(): FormGroup {
    return this.formBuilder.group({
      skill: '',
      exp: '',
    })
  }
 
  addSkills() {
    this.skills.push(this.newSkill());
  }
 
  removeSkill(i:number) {
    this.skills.removeAt(i);
  }
 
  onSubmit() {
    console.log(this.skillsForm.value);
  }


   

  // newSkill(): FormGroup {
  //   return this.fb.group({
  //     skill: '',
  //     exp: '',
  //   })
  // }
 
  // addSkills() {
  //   this.skills.push(this.newSkill());
  // }
 
  // removeSkill(i:number) {
  //   this.skills.removeAt(i);
  // }
 
  // onSubmit() {
  //   console.log(this.skillsForm.value);
  // }

  


}

export class country {
  id: string;
  name: string;
 
  constructor(id: string, name: string) {
    this.id = id;
    this.name = name;
  }
}