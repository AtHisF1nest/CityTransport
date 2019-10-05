import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GameComponent } from './game.component';
import { GridComponent } from './grid/grid.component';
import { GridElementComponent } from './grid-element/grid-element.component';
import { GuiComponent } from './gui/gui.component';
import { GuiElementComponent } from './gui-element/gui-element.component';
import { GuiElementVehicleComponent } from './gui-element-vehicle/gui-element-vehicle.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    GameComponent,
    GridComponent,
    GridElementComponent,
    GuiComponent,
    GuiElementComponent,
    GuiElementVehicleComponent
  ]
})
export class GameModule { }
