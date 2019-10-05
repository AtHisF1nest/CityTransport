import { Component, OnInit, Input } from '@angular/core';
import { MapField } from 'src/app/_models/MapField';

@Component({
  selector: 'app-grid-element',
  templateUrl: './grid-element.component.html',
  styleUrls: ['./grid-element.component.scss']
})
export class GridElementComponent implements OnInit {
  @Input()
  gridElement: MapField;

  constructor() { }

  ngOnInit() {
  }

}
