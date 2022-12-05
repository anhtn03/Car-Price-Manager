import {
  Component,
  OnInit,
} from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  sortKey: any;
  sortOptions: any;
  dv: any;
  constructor() { }

  ngOnInit(): void {
  }
  onSortChange() {}
}
