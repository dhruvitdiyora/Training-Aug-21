import { ComponentFixture, TestBed } from '@angular/core/testing';

import { P23Component } from './p23.component';

describe('P23Component', () => {
  let component: P23Component;
  let fixture: ComponentFixture<P23Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ P23Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(P23Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
