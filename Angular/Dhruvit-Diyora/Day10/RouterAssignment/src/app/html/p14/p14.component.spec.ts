import { ComponentFixture, TestBed } from '@angular/core/testing';

import { P14Component } from './p14.component';

describe('P14Component', () => {
  let component: P14Component;
  let fixture: ComponentFixture<P14Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ P14Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(P14Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
