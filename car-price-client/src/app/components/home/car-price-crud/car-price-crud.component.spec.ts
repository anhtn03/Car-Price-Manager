import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarPriceCrudComponent } from './car-price-crud.component';

describe('CarPriceCrudComponent', () => {
  let component: CarPriceCrudComponent;
  let fixture: ComponentFixture<CarPriceCrudComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CarPriceCrudComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CarPriceCrudComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
