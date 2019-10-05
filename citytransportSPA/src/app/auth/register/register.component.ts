import { Component, OnInit } from '@angular/core';
import { PlayerForm } from 'src/app/_models/PlayerForm';
import { AuthService } from 'src/app/_services/auth.service';
import { AlertifyService } from 'src/app/_services/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  model: PlayerForm = { };

  constructor(private authService: AuthService, private alertifyService: AlertifyService) { }

  ngOnInit() {
  }

  register() {
    this.authService.register(this.model).subscribe(() => {
      this.alertifyService.success('Rejestracja się powiodła!');
    }, error => {
      this.alertifyService.error('Przykro nam, coś poszło nie tak');
    });
  }

}
