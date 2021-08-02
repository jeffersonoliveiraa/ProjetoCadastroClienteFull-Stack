import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesComponent } from './clientes/clientes.component';
import { UsuariosComponent } from './usuarios/usuarios.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { PerfilComponent } from './perfil/perfil.component';
import { LoginComponent } from './login/login.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { AddClienteComponent } from './add-cliente/add-cliente.component';


const routes: Routes = [
  { path : '', redirectTo: 'login', pathMatch: 'full'},
  { path : 'dashboard', component: DashboardComponent },
  { path : 'clientes', component: ClientesComponent },
  { path : 'perfil', component: PerfilComponent },
  { path : 'usuarios', component: UsuariosComponent },
  { path : 'login', component: LoginComponent },
  { path : 'add-cliente', component: AddClienteComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes),ModalModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
