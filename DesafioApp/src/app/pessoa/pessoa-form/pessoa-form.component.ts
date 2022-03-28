import { Component, OnInit } from '@angular/core';
import { PessoaService } from 'src/app/shared/pessoa.service';

@Component({
  selector: 'app-pessoa-form',
  templateUrl: './pessoa-form.component.html',
  styles: [
  ]
})
export class PessoaFormComponent implements OnInit {

  constructor(public service:PessoaService) { }

  ngOnInit(): void {
  }

}
