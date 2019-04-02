import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GameComponent } from './game.component';
import { SharedModule } from '../shared/shared.module';
import { GameEmitterModule } from '../game-emitter/game-emitter.module';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    GameEmitterModule
  ],
  declarations: [GameComponent]
})
export class GameModule { }
