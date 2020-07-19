import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PerformencesComponent } from './performences.component';

describe('PerformencesComponent', () => {
  let component: PerformencesComponent;
  let fixture: ComponentFixture<PerformencesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PerformencesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PerformencesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
