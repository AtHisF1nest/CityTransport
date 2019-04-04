import { Component, OnInit, Input } from '@angular/core';
import { GameContainer } from '../interfaces/game-container';

@Component({
  selector: 'app-grid-container',
  templateUrl: './grid-container.component.html',
  styleUrls: ['./grid-container.component.scss']
})
export class GridContainerComponent implements OnInit {

  @Input() gameContainer: GameContainer;

  constructor() { }

  ngOnInit() {
  }

}
