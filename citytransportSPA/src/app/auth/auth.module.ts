import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthComponent } from './auth.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RouterModule } from '@angular/router';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  imports: [
    NgbModule,
    CommonModule,
    RouterModule,
    SharedModule
  ],
  declarations: [
    AuthComponent
  ]
})
export class AuthModule { }
