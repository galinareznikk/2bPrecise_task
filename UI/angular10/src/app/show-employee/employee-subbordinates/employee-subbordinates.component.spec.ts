import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeSubbordinatesComponent } from './employee-subbordinates.component';

describe('EmployeeSubbordinatesComponent', () => {
  let component: EmployeeSubbordinatesComponent;
  let fixture: ComponentFixture<EmployeeSubbordinatesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployeeSubbordinatesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeeSubbordinatesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
