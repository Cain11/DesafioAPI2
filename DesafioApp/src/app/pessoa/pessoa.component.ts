import { Component, OnInit } from '@angular/core';
import { PessoaService } from '../shared/pessoa.service';

@Component({
  selector: 'app-pessoa',
  templateUrl: './pessoa.component.html',
  styles: [
  ]
})
export class PessoaComponent implements OnInit {

  constructor(public service:PessoaService) { }

  ngOnInit(): void {
  }

}
