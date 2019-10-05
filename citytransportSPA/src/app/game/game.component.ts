import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { AlertifyService } from '../_services/alertify.service';
import { MapService } from '../_services/map.service';
import { MapField } from '../_models/MapField';
import { PlayerService } from '../_services/player.service';
import { PlayerInfo } from '../_models/PlayerInfo';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class GameComponent implements OnInit {

  gridElements: MapField[] = [];
  playerInfo: PlayerInfo;

  constructor(private alertifyService: AlertifyService, private mapService: MapService,
    private playerService: PlayerService) { }

  ngOnInit() {
    this.setGridElements();
    this.setPlayerInfo();
  }

  setGridElements() {
    this.mapService.getElements(1).subscribe(response => {
      this.gridElements = response;
    });
  }

  setPlayerInfo() {
    this.playerService.getPlayerInfo().subscribe(response => {
      this.playerInfo = response;
    });
  }
}
