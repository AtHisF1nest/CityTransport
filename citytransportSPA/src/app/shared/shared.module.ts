import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedComponent } from './shared.component';
import { LayoutComponent } from './layout/layout.component';
import { NavbarComponent } from './navbar/navbar.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    SharedComponent,
    LayoutComponent,
    NavbarComponent
  ],
  exports: [
    SharedComponent
  ]
})
export class SharedModule { }
