import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ErrorComponent } from '../error/error.component';
import { AngularComponent } from './angular/angular.component';
import { CircleComponent } from './circle/circle.component';
import { FormsModule } from '@angular/forms';
import { CalcComponent } from './calc/calc.component';
import { HelloWorldComponent } from './hello-world/hello-world.component';
import { RectangleComponent } from './rectangle/rectangle.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { LoginComponent } from './login/login.component';
import { BasicsComponent } from './basics/basics.component';


const routes: Routes = [{
  path: '', component: AngularComponent,
  children: [
    { path: 'day1/p1', component: CircleComponent },
    { path: 'day1/p2', component: CalcComponent },
    { path: 'day1/p3', component: HelloWorldComponent },
    { path: 'day1/p4', component: RectangleComponent },
    { path: 'day1/p5', component: SignUpComponent },
    { path: 'day1/a1', component: LoginComponent },
    { path: '**', component: BasicsComponent }


  ]
},
{ path: '**', component: ErrorComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule, FormsModule]
})
export class AngularRoutingModule { }
