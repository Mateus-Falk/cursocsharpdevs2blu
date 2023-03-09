import { NoteService } from './../../../services/note/note.service';
import { Note } from './../../../models/note-model';
import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-note-list',
  templateUrl: './note-list.component.html',
  styleUrls: ['./note-list.component.scss']
})
export class NoteListComponent implements OnInit{

  public noteList$ = new Subject<Note[] | undefined>();

  constructor(public service: NoteService){}

  ngOnInit(): void{
    this.service.getNoteList().subscribe(
      (resp) => {
        console.log(resp);
        this.noteList$.next(resp);
      }
    );
  }
}
