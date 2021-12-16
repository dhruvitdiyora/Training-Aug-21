import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ErrorComponent } from '../error/error.component';
import { A1Component } from './a1/a1.component';
import { A2Component } from './a2/a2.component';
import { BasicComponent } from './basic/basic.component';
import { HtmlMainComponent } from './html-main/html-main.component';
import { P11Component } from './p11/p11.component';
import { P12Component } from './p12/p12.component';
import { P13Component } from './p13/p13.component';
import { P14Component } from './p14/p14.component';
import { P15Component } from './p15/p15.component';
import { P21Component } from './p21/p21.component';
import { P22Component } from './p22/p22.component';
import { P23Component } from './p23/p23.component';
import { P24Component } from './p24/p24.component';
import { P25Component } from './p25/p25.component';

const routes: Routes =
  [{
    path: '', component: HtmlMainComponent,
    children: [
      { path: 'day1/p1', component: P11Component },
      { path: 'day1/p2', component: P12Component },
      { path: 'day1/p3', component: P13Component },
      { path: 'day1/p4', component: P14Component },
      { path: 'day1/p5', component: P15Component },
      { path: 'day1/a1', component: A1Component },
      { path: 'day2/p1', component: P21Component },
      { path: 'day2/p2', component: P22Component },
      { path: 'day2/p3', component: P23Component },
      { path: 'day2/p4', component: P24Component },
      { path: 'day2/p5', component: P25Component },
      { path: 'day2/a2', component: A2Component },
      { path: '**', component: BasicComponent }

    ]
  },
  { path: '**', component: ErrorComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HtmlRoutingModule { }
