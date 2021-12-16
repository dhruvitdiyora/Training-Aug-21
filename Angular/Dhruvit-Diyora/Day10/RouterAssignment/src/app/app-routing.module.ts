import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AngularComponent } from './angular/angular/angular.component';
import { HomeComponent } from './home/home.component';
import { LoggedinguardService } from './loggedinguard.service';
import { ErrorComponent } from './error/error.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  // { path: 'html', component: HtmlMainComponent,
  //   children: [
  //       { path: 'day1/p1', component: P11Component },
  //       { path: 'day1/p2', component: P12Component },
  //       { path: 'day1/p3', component: P13Component },
  //       { path: 'day1/p4', component: P14Component },
  //       { path: 'day1/p5', component: P15Component },
  //       { path: 'day1/a1', component: A1Component },
  //       { path: 'day2/p1', component: P21Component },
  //       { path: 'day2/p2', component: P22Component },
  //       { path: 'day2/p3', component: P23Component },
  //       { path: 'day2/p4', component: P24Component },
  //       { path: 'day2/p5', component: P25Component },
  //       { path: 'day2/a2', component: A2Component },
  //       { path: '', component: HomeComponent}
  //     ]
  // },
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'html', loadChildren: () => import('./html/html.module').then(m => m.HtmlModule), canActivate: [LoggedinguardService] },
  { path: 'angular', loadChildren: () => import('./angular/angular.module').then(m => m.AngularModule), canActivate: [LoggedinguardService] },

  { path: '**', component: ErrorComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
