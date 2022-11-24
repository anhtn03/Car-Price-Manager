import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { CarInfo } from '../app/models/CarInfo';

@Injectable({
  providedIn: 'root'
})
export class TestService {

  Image: string = ''

  Category: string = 'Suv'

  Store: string = 'CarHaNoi'

  CarName: string = "Volvo XC90"
  
  constructor(private httpclient: HttpClient) { }

  getItems() {
    return this.httpclient.get<any>('http://localhost:4200/test/Itemapi/Items.Json')
      .toPromise()
      .then(res => <CarInfo[]>res.data)
      .then(data => {return data})
  }

  generateItems(): CarInfo {
    const carInfo: CarInfo = {
      Name: this.CarName,
      Image: this.Image,
      Price: this.gereratePrice(),
      Category: this.Category,
      StoreAddress: this.Store,
      review: this.gererateReview(),
    }
    return carInfo;
  }

  gereratePrice() {
    return Math.floor(Math.random() * Math.floor(250)+3)
   }
  
  gererateReview() {
    return Math.floor(Math.random() * Math.floor(5))
  }
}
