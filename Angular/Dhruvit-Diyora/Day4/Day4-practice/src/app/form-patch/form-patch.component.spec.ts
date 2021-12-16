import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormPatchComponent } from './form-patch.component';

describe('FormPatchComponent', () => {
  let component: FormPatchComponent;
  let fixture: ComponentFixture<FormPatchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormPatchComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormPatchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
