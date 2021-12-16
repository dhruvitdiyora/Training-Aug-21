import { Component ,Input} from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Day8-Practice';
  Counter = 5;
  currentItem = 'Television';

  countChangedHandler(count: number) {
    this.Counter = count;
    console.log(count);
  }
 
  increment() {
    this.Counter++;
  }
  decrement() {
    this.Counter--;
  }

    items = ['item1', 'item2', 'item3', 'item4'];

    addItem(newItem: string) {
    this.items.push(newItem);
  }
}
