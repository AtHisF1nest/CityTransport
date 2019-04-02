import { Component, OnInit, Input } from '@angular/core';
import { GameContainer } from './interfaces/game-container';

@Component({
  selector: 'app-game-emitter',
  templateUrl: './game-emitter.component.html',
  styleUrls: ['./game-emitter.component.scss']
})
export class GameEmitterComponent implements OnInit {

  @Input() gameContainer: GameContainer;

  constructor() { }

  ngOnInit() {
    
  }

}
