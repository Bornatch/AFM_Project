import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { QuotesHistoriesComponent } from './quotes-histories.component';

describe('QuotesHistoriesComponent', () => {
  let component: QuotesHistoriesComponent;
  let fixture: ComponentFixture<QuotesHistoriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ QuotesHistoriesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(QuotesHistoriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
