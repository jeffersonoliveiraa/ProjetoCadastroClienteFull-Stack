/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { AddClienteService } from './add-cliente.service';

describe('Service: AddCliente', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [AddClienteService]
    });
  });

  it('should ...', inject([AddClienteService], (service: AddClienteService) => {
    expect(service).toBeTruthy();
  }));
});
