import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GameEmitterComponent } from './game-emitter.component';

@NgModule({
  imports: [
    CommonModule
  ],
  exports: [
    GameEmitterComponent
  ],
  declarations: [GameEmitterComponent]
})
export class GameEmitterModule { }
