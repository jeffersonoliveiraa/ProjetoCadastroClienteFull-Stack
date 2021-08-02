import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.css']
})
export class UsuariosComponent implements OnInit {

  public titulo = "Usuarios";

  public usuarios = [
    {nome: "Rebeca", idade: "14"},
    {nome: "Mateus"},
  ];

  constructor() { }

  ngOnInit() {
  }

}
