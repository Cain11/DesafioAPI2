import { Component, OnInit } from '@angular/core';
import { CidadeService } from 'src/app/shared/cidade.service';

@Component({
  selector: 'app-cidade-form',
  templateUrl: './cidade-form.component.html',
  styles: [
  ]
})
export class CidadeFormComponent implements OnInit {

  constructor(public service:CidadeService) { }

  ngOnInit(): void {
  }

}
