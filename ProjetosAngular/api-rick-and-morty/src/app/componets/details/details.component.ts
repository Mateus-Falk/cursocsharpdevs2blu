import { ApiService } from './../../service/api.service';
import { Character } from './../../models/api/character-model';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss']
})
export class DetailsComponent implements OnInit{

  public character:Character = new Character({});
  constructor(public service: ApiService,
              public route: ActivatedRoute){}

  ngOnInit(): void {
    let id = this.route.snapshot.paramMap.get('id');
    if(id){
      this.service.getCharacterById(id).subscribe(
        (resp) => {
          this.character = resp;
        }
      );
    }
  }
}
