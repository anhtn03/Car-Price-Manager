import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ButtonModule } from 'primeng/button';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { DialogService, DynamicDialogModule } from 'primeng/dynamicdialog';
import { MenubarModule } from 'primeng/menubar';
import { TableModule } from 'primeng/table';
import { TabMenuModule } from 'primeng/tabmenu';
import { ToastModule } from 'primeng/toast';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CarPriceCrudComponent } from './components/home/car-price-crud/car-price-crud.component';

import {
  MenubarComponent,
} from './components/layouts/menubar/menubar.component';
import {
  DialogPopupComponent,
} from './components/shared/dialog-popup/dialog-popup.component';
import {RatingModule} from 'primeng/rating';
import {FormsModule, NgControl, ReactiveFormsModule} from '@angular/forms';
import {DialogModule} from 'primeng/dialog';
import {FileUploadModule} from 'primeng/fileupload';
import {HttpClientModule} from '@angular/common/http';
import { PriceCarAddComponent } from './components/shared/dialog-popup/dialogs/price-car-add/price-car-add.component';
import { MessageService } from 'primeng/api';


@NgModule({
  declarations: [
    AppComponent,
    MenubarComponent,
    DialogPopupComponent,
    CarPriceCrudComponent,
    PriceCarAddComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    MenubarModule,
    TabMenuModule,
    DynamicDialogModule,
    DialogModule,
    ButtonModule,
    ConfirmDialogModule,
    TableModule,
    ToastModule,
    RatingModule,
    FormsModule,
    FileUploadModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [
    DialogService,
    MessageService,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
