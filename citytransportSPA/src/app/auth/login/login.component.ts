import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/_services/auth.service';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { PlayerForm } from 'src/app/_models/PlayerForm';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  model: PlayerForm = { };

  constructor(private authService: AuthService, private alertifyService: AlertifyService,
    private router: Router) { }

  ngOnInit() {
  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      this.alertifyService.success('Zalogowano pomyślnie!');
    }, error => {
      this.alertifyService.error('Logowanie nie powiodło się.');
    }, () => {
      this.router.navigate(['/graj']);
    });
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

  logout() {
    this.authService.logout();
    this.alertifyService.message('Będziemy na Ciebie czekać :)');
    this.router.navigate(['/']);
  }

}
