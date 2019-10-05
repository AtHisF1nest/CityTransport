import { Component, OnInit, Input, ViewEncapsulation } from '@angular/core';
import { PlayerInfo } from 'src/app/_models/PlayerInfo';
import { Vehicle } from 'src/app/_models/Vehicle';

@Component({
  selector: 'app-gui',
  templateUrl: './gui.component.html',
  styleUrls: ['./gui.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class GuiComponent implements OnInit {

  @Input()
  playerInfo: PlayerInfo;

  selectedVehicle: Vehicle;

  constructor() { }

  ngOnInit() {
  }

  onSelectedVehicle(vehicle: Vehicle) {
    this.selectedVehicle = vehicle;
  }

}
