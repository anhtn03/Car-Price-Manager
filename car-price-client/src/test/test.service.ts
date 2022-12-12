import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CarInfo } from '../app/models/CarInfo';

@Injectable({
  providedIn: 'root'
})
export class TestService {

  Image: string = ''

  CategoryName: string[] = ["SUV", "CUV", "MPV", "SEDAN", "4X4"]

  Name: string[] = ["Volvo XC90", "CX5", "CARNIVAL", "Vios","RAPTOR-F150"]
  
  constructor(private httpclient: HttpClient) { }

  getProduct() {
    return this.httpclient.get<any>('src/test/product.json')
      .toPromise()
      .then((res) => <CarInfo[]>res.data)
      .then(data => {
        return data
      })
      }

  generateProducts(): CarInfo {
    const carInfo: CarInfo = {
      Id: this.generateId(),
      Name: this.generateCarName(), 
      Image: this.Image,
      Price: this.gereratePrice(),
      Category: this.generateCategory(),
      StoreAddress: "CarThanhXuan",
      rating: this.gererateReview(),
    }
    return carInfo;
  }

  generateCarName() {
    return this.Name[Math.floor(Math.random() * Math.floor(5))]
  }

  generateCategory() {
    return this.CategoryName[Math.floor(Math.random() * Math.floor(5))]
  }

  generateId() {
    return Math.floor(Math.random() * 10)
  }

  gereratePrice() {
    return Math.floor(Math.random() * Math.floor(250)+3)
  }
  
  gererateReview() {
    return Math.floor(Math.random() * Math.floor(5))
  }
}
