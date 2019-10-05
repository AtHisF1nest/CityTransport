import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StaticComponent } from './static/static.component';
import { AuthComponent } from './auth/auth.component';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { AuthGuard } from './_guards/auth.guard';
import { GameComponent } from './game/game.component';

const routes: Routes = [
  { path: '', component: AuthComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'graj', component: GameComponent },
    ]
  },
  { path: 'logowanie', component: LoginComponent },
  { path: 'rejestracja', component: RegisterComponent },
  { path: '**', redirectTo: '', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
