import { ContatoService } from './service/contato.service';
import {  HttpClientModule } from '@angular/common/http';
import {  CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './component/home/home.component';
import { ListContatosComponent } from './component/list-contatos/list-contatos.component';
import { AddContatoComponent } from './component/add-contato/add-contato.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ListContatosComponent,
    AddContatoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    CommonModule,
    ReactiveFormsModule
  ],
  providers: [HttpClientModule, ContatoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
