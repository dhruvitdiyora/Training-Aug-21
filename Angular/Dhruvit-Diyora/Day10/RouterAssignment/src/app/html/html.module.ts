import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HtmlRoutingModule } from './html-routing.module';
import { P11Component } from './p11/p11.component';
import { P12Component } from './p12/p12.component';
import { P13Component } from './p13/p13.component';
import { P14Component } from './p14/p14.component';
import { P15Component } from './p15/p15.component';
import { A1Component } from './a1/a1.component';
import { P21Component } from './p21/p21.component';
import { P22Component } from './p22/p22.component';
import { P23Component } from './p23/p23.component';
import { P24Component } from './p24/p24.component';
import { P25Component } from './p25/p25.component';
import { A2Component } from './a2/a2.component';
import { HtmlMainComponent } from './html-main/html-main.component';
import { BasicComponent } from './basic/basic.component';


@NgModule({
  declarations: [

    HtmlMainComponent,
    P11Component,
    P12Component,
    P13Component,
    P14Component,
    P15Component,
    A1Component,
    P21Component,
    P22Component,
    P23Component,
    P24Component,
    P25Component,
    A2Component,
    BasicComponent,
  ],
  imports: [
    CommonModule,
    HtmlRoutingModule
  ]
})
export class HtmlModule { }
