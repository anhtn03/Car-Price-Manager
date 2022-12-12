import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarPriceProductsComponent } from './car-price-products.component';

describe('CarPriceProductsComponent', () => {
  let component: CarPriceProductsComponent;
  let fixture: ComponentFixture<CarPriceProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CarPriceProductsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CarPriceProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
