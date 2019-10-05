import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { MapField } from '../_models/MapField';

@Injectable({
  providedIn: 'root'
})
export class MapService {

  baseUrl = environment.apiUrl + 'map/';

  constructor(private http: HttpClient) { }

  getElements(cityId: number): Observable<MapField[]> {
    return this.http.get<MapField[]>(this.baseUrl + 'getFields/' + cityId);
  }

}
