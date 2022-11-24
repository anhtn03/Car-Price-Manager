import { Component, OnInit } from '@angular/core';
import { DynamicDialogRef } from 'primeng/dynamicdialog';

@Component({
  selector: 'app-dialog-popup',
  templateUrl: './dialog-popup.component.html',
  styleUrls: ['./dialog-popup.component.css']
})
export class DialogPopupComponent{
  public ref: DynamicDialogRef
  constructor(
  ) { }

  public close() {
    this.cancle(false)
  }

  public cancle(value: any) {
    this.ref.close(value);
  }

  public confirm() {
    this.cancle(true);
  }

}
