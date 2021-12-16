import { ComponentFixture, TestBed } from '@angular/core/testing';

import { P13Component } from './p13.component';

describe('P13Component', () => {
  let component: P13Component;
  let fixture: ComponentFixture<P13Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ P13Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(P13Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
