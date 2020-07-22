import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PerformencesIndexComponent } from './performences-index.component';

describe('PerformencesIndexComponent', () => {
  let component: PerformencesIndexComponent;
  let fixture: ComponentFixture<PerformencesIndexComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PerformencesIndexComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PerformencesIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
