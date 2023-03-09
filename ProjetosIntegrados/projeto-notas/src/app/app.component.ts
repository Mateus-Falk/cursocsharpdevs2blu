import { UserService } from './services/user/user.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'projeto-notas';

  constructor(private service: UserService){
    this.service.getUserName().subscribe(
      (response) => {
        console.log(response);
      }
    )
  }
}
