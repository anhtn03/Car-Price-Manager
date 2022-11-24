import { Component, OnInit } from '@angular/core';
import { FormControl, FormControlName, FormGroup } from '@angular/forms';
import { MessageService } from 'primeng/api';
import { DynamicDialogRef } from 'primeng/dynamicdialog';
import { filter, map, Subject, withLatestFrom } from 'rxjs';
import { CarInfo } from 'src/app/models/CarInfo';
import { CarDetailService } from 'src/app/services/car-detail.service';
import { DialogPopupComponent } from '../../dialog-popup.component';

@Component({
  selector: 'app-price-car-add',
  templateUrl: './price-car-add.component.html',
  styleUrls: ['./price-car-add.component.css']
})
export class PriceCarAddComponent extends DialogPopupComponent implements OnInit {

  constructor(override ref: DynamicDialogRef, private carDetailService: CarDetailService, private messageService: MessageService ) {
    super()
   }
  createCarDetail = new FormGroup ({
   name: new FormControl(''),
   price: new FormControl(),
   category: new FormControl(),
   store: new FormControl(''),
   review: new FormControl(),
  });

  submitted: boolean;

  formSubmit$ = new Subject<void>();
  
  Item: CarInfo;

  Items: CarInfo[];

  ngOnInit(): void {
    this.formSubmit$.pipe(withLatestFrom(this.createCarDetail.valueChanges.pipe()),
    map(([, value]) => value as CarInfo))
    .subscribe((value) => {
       this.carDetailService.createItem(value)
        .subscribe(res => { 
          this.confirm()
          this.messageService.add({severity:'success', summary: 'Successful', detail: 'Product Deleted', life: 3000});
       })
    })  
  }

  save() {
    this.submitted = true
    this.formSubmit$.next()
  }
  
  skip() {
    this.close()
  }

  onUpload() {}
}
