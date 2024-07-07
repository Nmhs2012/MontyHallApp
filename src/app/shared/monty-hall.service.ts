import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MontyHallService {

  private apiUrl  = environment.apiBaseUrl + '/simulate'
  constructor(private http: HttpClient) { }

  simulateGames(numberOfGames: number, changeDoor: boolean): Observable<any> {
    let params = new HttpParams()
      .set('numberOfGames', numberOfGames.toString())
      .set('changeDoor', changeDoor.toString());
      
      return this.http.get(this.apiUrl, { params });
  }
}
