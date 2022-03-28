import { Injectable } from '@angular/core';
import { Cidade } from './cidade.model';

@Injectable({
  providedIn: 'root'
})
export class CidadeService {

  constructor() { }

  formData: Cidade =  new Cidade();
}
