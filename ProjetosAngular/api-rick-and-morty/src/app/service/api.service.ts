import { Character } from './../models/api/character-model';
import { ApiReturn } from './../models/api-return/api-return';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  public URL_API: string = 'https://rickandmortyapi.com/api/character';

  constructor(public http: HttpClient) { }

  getCharacterList(){
    return this.http.get<ApiReturn>(this.URL_API);
  }

  getCharacterById(id: string){
    return this.http.get<Character>(`${this.URL_API}/${id}`)
  }
}
