import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Vehicle } from 'src/app/_models/Vehicle';

@Component({
  selector: 'app-gui-element-vehicle',
  templateUrl: './gui-element-vehicle.component.html',
  styleUrls: ['./gui-element-vehicle.component.scss']
})
export class GuiElementVehicleComponent implements OnInit {
  @Input()
  vehicle: Vehicle;

  @Output()
  selectedVehicle: EventEmitter<Vehicle> = new EventEmitter<Vehicle>();

  constructor() { }

  ngOnInit() {
  }

  selectVehicle() {
    this.vehicle.isSelected = true;
    this.selectedVehicle.emit(this.vehicle);
  }

}
