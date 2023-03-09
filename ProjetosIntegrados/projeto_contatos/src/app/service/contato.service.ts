import { Contato, } from './../models/contato-model';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class ContatoService {

  public URL_API: string = 'https://localhost:7049/api/Contatos';
  constructor(private http: HttpClient) { }

  getContatosList(): Observable<Contato[]>{
    return this.http.get<Contato[]>(this.URL_API);
  }

  getContato(id: number): Observable<Contato>{
    return this.http.get<Contato>(`${this.URL_API}/${id}`)
  }

  saveContato(contato: Contato) : Observable<any>{
    return this.http.post<Contato>(this.URL_API, contato, httpOptions);
  }

  updateContato(contato: Contato) : Observable<any>{
    return this.http.put<Contato>(this.URL_API,contato, httpOptions);
  }

  deleteContato(id: number) : Observable<Contato>{
    return this.http.delete<Contato>(`${this.URL_API}/${id}`,httpOptions)
  }
}
