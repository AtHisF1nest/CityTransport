import { Component, OnInit } from '@angular/core';
import { GameContainer } from '../game-emitter/interfaces/game-container';
import { WindowSpecification } from '../game-emitter/interfaces/window-specification';
import { AssetsSpecification } from '../game-emitter/interfaces/assets-specification';
import { ElementsSpecification } from '../game-emitter/interfaces/elements-specification';
import { GuiSpecification } from '../game-emitter/interfaces/gui-specification';
import { GuiPosition } from '../game-emitter/enums/gui-position.enum';
import { EventElement } from '../game-emitter/interfaces/event-element';
import { EventType } from '../game-emitter/enums/event-type.enum';
import { GameElement } from '../game-emitter/interfaces/game-element';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.scss']
})
export class GameComponent implements OnInit {

  gameContainer: GameContainer;
  windowSpec: WindowSpecification;
  assetsSpec: AssetsSpecification;
  elementsSpec: ElementsSpecification;
  guiSpec: GuiSpecification;

  constructor() { }

  ngOnInit() {
    this.windowSpec = {
      name: 'CityTransport',
      height: 600,
      width: 1100,
      zoom: 1
    };

    this.assetsSpec = {
      images: new Array()
    };

    this.elementsSpec = {
      grid: new Array(),
      gridHeight: 12,
      gridWidth: 22
    };

    for (let i = 0; i < 264; i++) {
      const eventsArray: Array<EventElement> = new Array();
      eventsArray.push({
        eventType: EventType.OnClick,
        eventFunction: function(sender: GameElement) {
          
        }
      });

      this.elementsSpec.grid.push(
        { name: 'field', xCord: 0, yCord: 0,  gridWidth: 1, gridHeight: 1, imageElement: null, 
        childGameElement: null, events: eventsArray, styles: null }
      );
    }

    this.guiSpec = {
      guiElements: new Array(),
      height: 50,
      width: 100,
      position: GuiPosition.LeftUpperCorner
    }

    this.gameContainer = {
      windowSpec: this.windowSpec,
      assetsSpec: this.assetsSpec,
      elementsSpec: this.elementsSpec,
      guiSpec: this.guiSpec
    };
  }

}
