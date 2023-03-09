import { Note } from './../../models/note-model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class NoteService {

  public URL_NOTE: string = 'https://localhost:7193/api/Note';

  constructor(public http: HttpClient) { }

  getNoteList(){
    return this.http.get<Note[]>(this.URL_NOTE)
  }
}
