import { User } from './../../models/user-model';
import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  public URL_USER: string = 'https://localhost:7193/api/User';

  constructor(private http: HttpClient) { }

  getUserName(){
    return this.http.get<User[]>(this.URL_USER);
  }
}
