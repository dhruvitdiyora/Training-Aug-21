import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AngularRoutingModule } from './angular-routing.module';
import { AngularComponent } from './angular/angular.component';
import { FormsModule } from '@angular/forms';
import { CircleComponent } from './circle/circle.component';
import { CalcComponent } from './calc/calc.component';
import { HelloWorldComponent } from './hello-world/hello-world.component';
import { RectangleComponent } from './rectangle/rectangle.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { LoginComponent } from './login/login.component';
import { BasicsComponent } from './basics/basics.component';



@NgModule({
  declarations: [
    AngularComponent,
    CircleComponent,
    CalcComponent,
    HelloWorldComponent,
    RectangleComponent,
    SignUpComponent,
    LoginComponent,
    BasicsComponent
  ],
  imports: [
    CommonModule,
    AngularRoutingModule,
    FormsModule
  ]
})
export class AngularModule { }
