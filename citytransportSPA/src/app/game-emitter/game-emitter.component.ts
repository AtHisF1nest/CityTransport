import { Component, OnInit, Input } from '@angular/core';
import { GameContainer } from './interfaces/game-container';
import { GameElement } from './interfaces/game-element';
import { send } from 'q';
import { EventType } from './enums/event-type.enum';

@Component({
  selector: 'app-game-emitter',
  templateUrl: './game-emitter.component.html',
  styleUrls: ['./game-emitter.component.scss']
})
export class GameEmitterComponent implements OnInit {

  @Input() gameContainer: GameContainer;
  elementWidth: number;
  elementHeight: number;
  gridWidth: number;
  gridHeight: number;

  constructor() { }

  ngOnInit() {
    this.elementWidth = this.gameContainer.windowSpec.width / this.gameContainer.elementsSpec.gridWidth;
    this.elementHeight = this.gameContainer.windowSpec.height / this.gameContainer.elementsSpec.gridHeight;

    this.gridWidth = this.gameContainer.windowSpec.width;
    this.gridHeight = this.gameContainer.windowSpec.height;
  }

  gridElementClick(sender: GameElement) {
    sender.events.forEach(event => {
      if(event.eventType === EventType.OnClick) {
        event.eventFunction(sender);
      }
    });
  }

}
