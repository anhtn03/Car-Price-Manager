import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { CarInfo } from '../models/CarInfo';
import { productReq } from '../models/product/productReq';
import { productResp } from '../models/product/productResp';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private readonly productApi: string
  constructor(
    private readonly httpClient: HttpClient) {
    this.productApi = new URL(`api/product`, environment.apiUrl).href }


  getAllProducts(req: productReq) {
    return this.httpClient.post<productResp>(this.productApi, req);
  }
}
