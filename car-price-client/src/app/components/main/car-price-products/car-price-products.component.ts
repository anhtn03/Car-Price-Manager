import {
  Component,
  OnInit,
} from '@angular/core';
import { BehaviorSubject, take } from 'rxjs';

import { CarInfo } from 'src/app/models/CarInfo';
import { PageChangedProduct } from 'src/app/models/PageChangedItem';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-car-price-products',
  templateUrl: './car-price-products.component.html',
  styleUrls: ['./car-price-products.component.css']
})
export class CarPriceProductsComponent implements OnInit {
  onPageChanged$ = new BehaviorSubject<PageChangedProduct>({
    skip : 0,
    take : 50,
    total : 0,
  })
  dataSource: CarInfo[];

  constructor(private productService: ProductService) { }

  ngOnInit() {
    this.productService.getAllProducts
  }

}
