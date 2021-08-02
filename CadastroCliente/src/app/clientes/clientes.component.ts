import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {

  public titulo = 'Clientes';

  public clientes = [
    {nome: 'Jefferson'},
    {nome: 'Digley'}
  ];

  constructor() { }

  ngOnInit() {
  }

  opernModal(){
    
  }

}
