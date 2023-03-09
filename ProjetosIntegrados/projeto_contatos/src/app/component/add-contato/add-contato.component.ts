import { ContatoService } from './../../service/contato.service';
import { Contato } from './../../models/contato-model';
import { FormControl, FormGroup } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-contato',
  templateUrl: './add-contato.component.html',
  styleUrls: ['./add-contato.component.scss']
})
export class AddContatoComponent implements OnInit{


  formulario: any;
  tituloFormulario: string = '';

  constructor(private service: ContatoService) {}

  ngOnInit(): void{

    this.tituloFormulario = 'Novo Contato';
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      telefone: new FormControl(null),
      estado: new FormControl(null),
      cidade: new FormControl(null),
      bairro: new FormControl(null)
    })
  }

  SendForm(): void {
    this.service.saveContato(this.formulario.value).subscribe( result => {
      alert(`Contato salvo!`)
    })
  }

}
