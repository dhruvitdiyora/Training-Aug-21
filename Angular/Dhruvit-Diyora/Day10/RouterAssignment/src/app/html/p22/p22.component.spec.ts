import { ComponentFixture, TestBed } from '@angular/core/testing';

import { P22Component } from './p22.component';

describe('P22Component', () => {
  let component: P22Component;
  let fixture: ComponentFixture<P22Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ P22Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(P22Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
