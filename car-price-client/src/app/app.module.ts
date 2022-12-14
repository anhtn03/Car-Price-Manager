import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import {
  FormsModule,
  ReactiveFormsModule,
} from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MessageService } from 'primeng/api';
import { CheckboxModule } from 'primeng/checkbox';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { DataViewModule } from 'primeng/dataview';
import { DialogModule } from 'primeng/dialog';
import {
  DialogService,
  DynamicDialogModule,
} from 'primeng/dynamicdialog';
import { FileUploadModule } from 'primeng/fileupload';
import { MenubarModule } from 'primeng/menubar';
import { PanelMenuModule } from 'primeng/panelmenu';
import { RatingModule } from 'primeng/rating';
import { TableModule } from 'primeng/table';
import { TabMenuModule } from 'primeng/tabmenu';
import { ToastModule } from 'primeng/toast';
import { TestService } from 'src/test/test.service';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {
  CarPriceProductsComponent,
} from './components/main/car-price-products/car-price-products.component';
import {
  DialogPopupComponent,
} from './components/shared/dialog-popup/dialog-popup.component';
import {
  PriceCarAddComponent,
} from './components/shared/dialog-popup/dialogs/price-car-add/price-car-add.component';
import { HeaderComponent } from './components/header/header.component';

@NgModule({
  declarations: [
    AppComponent,
    DialogPopupComponent,
    PriceCarAddComponent,
    CarPriceProductsComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    MenubarModule,
    TabMenuModule,
    DynamicDialogModule,
    DialogModule,
    ConfirmDialogModule,
    TableModule,
    ToastModule,
    RatingModule,
    FormsModule,
    FileUploadModule,
    HttpClientModule,
    ReactiveFormsModule,
    DataViewModule,
    PanelMenuModule,
    CheckboxModule
  ],
  providers: [
    DialogService,
    MessageService,
    TestService,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
