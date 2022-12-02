import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { DialogService, DynamicDialogModule } from 'primeng/dynamicdialog';
import { MenubarModule } from 'primeng/menubar';
import { TableModule } from 'primeng/table';
import { TabMenuModule } from 'primeng/tabmenu';
import { ToastModule } from 'primeng/toast';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {DataViewModule} from 'primeng/dataview';
import {
  DialogPopupComponent,
} from './components/shared/dialog-popup/dialog-popup.component';
import {RatingModule} from 'primeng/rating';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {DialogModule} from 'primeng/dialog';
import {FileUploadModule} from 'primeng/fileupload';
import {HttpClientModule} from '@angular/common/http';
import { PriceCarAddComponent } from './components/shared/dialog-popup/dialogs/price-car-add/price-car-add.component';
import { MessageService } from 'primeng/api';
import { CarPriceProductsComponent } from './components/car-price-products/car-price-products.component';
import { TestService } from 'src/test/test.service';
import {PanelMenuModule} from 'primeng/panelmenu';
import {CheckboxModule} from 'primeng/checkbox';

@NgModule({
  declarations: [
    AppComponent,
    DialogPopupComponent,
    PriceCarAddComponent,
    CarPriceProductsComponent
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
