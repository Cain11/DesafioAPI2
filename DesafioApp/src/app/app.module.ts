import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule} from "@angular/forms";

import { AppComponent } from './app.component';
import { PessoaComponent } from './pessoa/pessoa.component';
import { CidadeComponent } from './cidade/cidade.component';
import { PessoaFormComponent } from './pessoa/pessoa-form/pessoa-form.component';
import { CidadeFormComponent } from './cidade/cidade-form/cidade-form.component';

@NgModule({
  declarations: [
    AppComponent,
    PessoaComponent,
    CidadeComponent,
    PessoaFormComponent,
    CidadeFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
