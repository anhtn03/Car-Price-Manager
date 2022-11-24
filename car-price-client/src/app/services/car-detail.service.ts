import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { CarInfo } from '../models/CarInfo';
import { ItemReps } from '../models/Items/ItemReps';
import { ItemReq } from '../models/Items/ItemReq';

@Injectable({
  providedIn: 'root'
})
export class CarDetailService {
   
  private readonly urlApi: string

  constructor(private readonly httpClient: HttpClient,) {
    this.urlApi = new URL(`/api/cardetail`, environment.apiUrl).href;
   }

   createItem(req: CarInfo) {
    return this.httpClient.post(this.urlApi + `/create`, req)
   }

   getAllItem(req: ItemReq) {
    return this.httpClient.post<ItemReps>(this.urlApi + `/getAll`, req)
   }
}
