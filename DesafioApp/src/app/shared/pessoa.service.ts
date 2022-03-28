import { Injectable } from '@angular/core';
import { Pessoa } from './pessoa.model';

@Injectable({
  providedIn: 'root'
})
export class PessoaService {

  constructor() { }

  formData: Pessoa =  new Pessoa();
  
}
