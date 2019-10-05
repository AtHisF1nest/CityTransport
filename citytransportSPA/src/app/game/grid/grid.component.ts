import { Component, OnInit, Input } from '@angular/core';
import { MapField } from 'src/app/_models/MapField';

@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
  styleUrls: ['./grid.component.scss']
})
export class GridComponent implements OnInit {

  @Input()
  gridElements: MapField[] = [];

  constructor() { }

  ngOnInit() {
  }

}
