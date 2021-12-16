import { Component } from '@angular/core';
import { Product } from './Product';
import { ProductService } from './product.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Day9-Practice';
  products: Product[] = [];

  constructor(private productService: ProductService) { }

  getProducts() {
    this.products = this.productService.getProducts();
  }
}
