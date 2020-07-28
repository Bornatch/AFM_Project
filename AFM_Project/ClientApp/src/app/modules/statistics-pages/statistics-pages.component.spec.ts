import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StatisticsPagesComponent } from './statistics-pages.component';

describe('StatisticsPagesComponent', () => {
  let component: StatisticsPagesComponent;
  let fixture: ComponentFixture<StatisticsPagesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StatisticsPagesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StatisticsPagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
