import { AddContatoComponent } from './component/add-contato/add-contato.component';
import { ListContatosComponent } from './component/list-contatos/list-contatos.component';
import { HomeComponent } from './component/home/home.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: '', redirectTo: '/home', pathMatch: 'full'},
  {path: 'list', component: ListContatosComponent},
  {path: 'newcontato', component: AddContatoComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
