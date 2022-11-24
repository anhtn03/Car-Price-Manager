import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PriceCarAddComponent } from './price-car-add.component';

describe('PriceCarAddComponent', () => {
  let component: PriceCarAddComponent;
  let fixture: ComponentFixture<PriceCarAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PriceCarAddComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PriceCarAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
