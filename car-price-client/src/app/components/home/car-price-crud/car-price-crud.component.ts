import {
  Component,
  OnInit,
} from '@angular/core';
import { BehaviorSubject, map, merge, Subject, switchMap, tap, withLatestFrom } from 'rxjs';
import { DefaultPaging } from 'src/app/common/constants';
import { PageChangedItem } from 'src/app/models/PageChangedItem';
import { SortChangedItem } from 'src/app/models/SortChangedItem';
import { CarDetailService } from 'src/app/services/car-detail.service';

import { DialogPopupService } from 'src/app/services/dialog-popup.service';
import { TestService } from 'src/test/test.service';

import { CarInfo } from '../../../models/CarInfo';

@Component({
  selector: 'app-restaurant-manager-crud',
  templateUrl: './car-price-crud.component.html',
  styleUrls: ['./car-price-crud.component.css']
})
export class CarPriceCrudComponent implements OnInit {

  selectedItems: CarInfo[];

  Items: CarInfo[];

  Item: CarInfo;

  getItems = new Subject();

  onPageChanged = new BehaviorSubject<PageChangedItem>({
    skip: 0,
    take: DefaultPaging.defaultPageSize,
    total: 0,
  } as PageChangedItem);

  onSort = new BehaviorSubject<SortChangedItem>({
    SortField: 'null',
    SortDirection: 'null'
  })
  
  constructor(private dialogPopupService: DialogPopupService, private testService: TestService, private carDetailService: CarDetailService) { }

  ngOnInit(): void {
    // this.testService.getItems().then(data => this.Items = data)
    merge(this.onPageChanged, this.onSort, this.getItems).pipe(
      withLatestFrom(this.onPageChanged, this.onSort),
      map(([, pagingValue, sortingValue]) => ({
        pagingValue,
        sortingValue,
      })),
      switchMap((item) =>
        this.carDetailService.getAllItem({
          skip: item.pagingValue.skip,
          take: item.pagingValue.take,
        })
      )
    )
  }

  openAdd() {
   this.dialogPopupService.showdialog()
   }
  
  deleteSelectedItem() { }
  
  editPriceCar() { }
  
  deleteItem() {}
}
