import { Injectable } from '@angular/core';
import { MessageService } from 'primeng/api';
import { DialogService, DynamicDialogRef } from 'primeng/dynamicdialog';
import { PriceCarAddComponent } from '../components/shared/dialog-popup/dialogs/price-car-add/price-car-add.component';

@Injectable({
  providedIn: 'root'
})
export class DialogPopupService {

  constructor(private dialogService: DialogService, private messageService: MessageService) { }
    ref: DynamicDialogRef

  
  showdialog() {
    this.ref = this.dialogService.open(PriceCarAddComponent, {  
      width: '500px',
      header: 'Thông tin chi tiết'
    })
  }
}
