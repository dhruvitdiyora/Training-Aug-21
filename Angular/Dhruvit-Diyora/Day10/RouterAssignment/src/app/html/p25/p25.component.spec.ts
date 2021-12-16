import { ComponentFixture, TestBed } from '@angular/core/testing';

import { P25Component } from './p25.component';

describe('P25Component', () => {
  let component: P25Component;
  let fixture: ComponentFixture<P25Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ P25Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(P25Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
