import { ApiService } from './../../service/api.service';
import { Results } from './../../models/api-return/api-return';
import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit{

  public resultsList$ = new Subject<Results[] | undefined>();

  constructor(public service: ApiService){}

  ngOnInit(): void {
    this.service.getCharacterList().subscribe(
      (resp) => {
        console.log(resp);
        this.resultsList$.next(resp.results);
      }
    )
  }
}
