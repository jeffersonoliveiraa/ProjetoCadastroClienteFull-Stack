import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Cliente } from '../model/Cliente';
import { AddClienteService } from './add-cliente.service';

@Component({
  selector: 'app-add-cliente',
  templateUrl: './add-cliente.component.html',
  styleUrls: ['./add-cliente.component.css']
})
export class AddClienteComponent implements OnInit {

  constructor(public addclienteservice: AddClienteService, private router: Router) { }

  ngOnInit() {
  }

  clienteForm = new FormGroup({
    nome: new FormControl(''),
    email: new FormControl(''),
    logradouro: new FormControl(''),
    numero: new FormControl(''),
    complemento: new FormControl(''),
    cep: new FormControl(''),
    bairro: new FormControl(''),
    cidade: new FormControl(''),
    estado: new FormControl(''),
  });


  onSubmit(){
    debugger
    const clienteData = this.clienteForm.patchValue(Cliente);
    this.addclienteservice.CreateCliente(clienteData).subscribe((response) => {
      const resultCadastrosCliente = response.body;
      debugger
      if (resultCadastrosCliente) {
        this.router.navigateByUrl('/clientes');
      }

    });
  }
}

