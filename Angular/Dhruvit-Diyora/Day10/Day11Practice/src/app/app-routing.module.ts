import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactComponent } from './contact/contact.component';
import { ErrorComponent } from './error/error.component';
import { HomeComponent } from './home/home.component';
import { OverviewComponent } from './overview/overview.component';
import { ProductDetailComponent } from './product-detail/product-detail.component';
import { ProductComponent } from './product/product.component';
import { SpecComponent } from './spec/spec.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'contact', component: ContactComponent },
  { path: 'product', component: ProductComponent, 
      children: [
        { path: 'detail/:id', component: ProductDetailComponent, 
            children : [
                { path: 'overview', component: OverviewComponent },
                { path: 'spec', component: SpecComponent },  
                { path: '', redirectTo:'overview', pathMatch:"full" }
            ]
        }
      ]
    },
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: '**', component: ErrorComponent }
];


@NgModule({
  imports: [RouterModule.forRoot(routes,{
        enableTracing: false, // <-- debugging purposes only
      })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
