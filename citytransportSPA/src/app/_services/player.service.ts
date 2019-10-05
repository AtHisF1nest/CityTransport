import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PlayerInfo } from '../_models/PlayerInfo';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PlayerService {

  baseUrl = environment.apiUrl + 'player/';

constructor(private http: HttpClient) { }

  getPlayerInfo(): Observable<PlayerInfo> {
    return this.http.get<PlayerInfo>(this.baseUrl + 'getPlayerInfo');
  }
}
