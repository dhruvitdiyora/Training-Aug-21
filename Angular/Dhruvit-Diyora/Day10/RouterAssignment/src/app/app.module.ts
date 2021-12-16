import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';

//import { CircleComponent } from '../../../../Day1/Practice/demoAoo/src/app/circle/circle.component';
import { HeaderComponent } from './header/header.component';
import { AUTH_PROVIDERS } from './auth.service';
import { LoggedinguardService } from './loggedinguard.service';

import { ErrorComponent } from './error/error.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    ErrorComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [AUTH_PROVIDERS,
    LoggedinguardService,],
  bootstrap: [AppComponent]
})
export class AppModule { }
