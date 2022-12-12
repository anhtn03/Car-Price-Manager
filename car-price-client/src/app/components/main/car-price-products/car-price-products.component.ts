import {
  Component,
  OnInit,
} from '@angular/core';

import { CarInfo } from 'src/app/models/CarInfo';
import { TestService } from 'src/test/test.service';

@Component({
  selector: 'app-car-price-products',
  templateUrl: './car-price-products.component.html',
  styleUrls: ['./car-price-products.component.css']
})
export class CarPriceProductsComponent implements OnInit {
  cars: CarInfo[];
  constructor(private testService: TestService) { }

  ngOnInit() {
  }

}
