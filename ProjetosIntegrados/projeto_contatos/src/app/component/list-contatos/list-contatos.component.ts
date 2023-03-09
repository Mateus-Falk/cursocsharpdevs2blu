import { ContatoService } from './../../service/contato.service';
import { Contato } from './../../models/contato-model';
import { Component, OnInit } from '@angular/core';
import { Subject } from "rxjs";
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-list-contatos',
  templateUrl: './list-contatos.component.html',
  styleUrls: ['./list-contatos.component.scss']
})
export class ListContatosComponent implements OnInit{

  public resultList$ = new Subject<Contato[] | undefined>();

  constructor(private service: ContatoService){}

  ngOnInit(): void{
    this.service.getContatosList().subscribe(
      resp => {
        console.log(resp);


        this.resultList$.next(resp);
      }
    )

  }
}
