import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HtmlMainComponent } from './html-main.component';

describe('HtmlMainComponent', () => {
  let component: HtmlMainComponent;
  let fixture: ComponentFixture<HtmlMainComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HtmlMainComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HtmlMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
