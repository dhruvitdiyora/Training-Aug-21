import { Component, OnChanges,Input,Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-child-component',
  templateUrl: './child-component.component.html',
  styleUrls: ['./child-component.component.css']
})
export class ChildComponentComponent {
  @Input() count: number = 0;
    @Input() item = '';
  @Output() countChanged: EventEmitter<number> = new EventEmitter();
  @Output() newItemEvent = new EventEmitter<string>();

  increment() {
        this.count++;
        this.countChanged.emit(this.count);
      }
    decrement() {
        this.count--;
        this.countChanged.emit(this.count);
    }
  addNewItem(value: string) {
    this.newItemEvent.emit(value);
  }


}
