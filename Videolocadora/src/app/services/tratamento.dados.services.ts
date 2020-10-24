import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TratamentoDadosService {
  
  constructor() { }

  getDataString(date: string) : string{
    if (date === '' || date === undefined || date.length < 10){
      return '';
    }
      
    let year = date.substring(0, 4);
    let month = date.substring(5, 7);
    let day = date.substring(8, 10);
    return `${day}/${month}/${year}`;
  }

  getDateNascimento(nascimento: any): Date{
    if (nascimento == undefined || nascimento == '' || nascimento.length < 8) return null;
    let dia: any;
    let mes: any;
    let ano: any;
    if (nascimento.length == 8) {
      dia = nascimento.substring(0,2);
      mes = nascimento.substring(2,4);
      ano = nascimento.substring(4,8);
    } else {
      dia = nascimento.substring(0,2);
      mes = nascimento.substring(3,5);
      ano = nascimento.substring(6,10);
    }
    return new Date(ano, (mes - 1), dia);
  }

  maskAdapterFone(fone: any) : string {
    if (fone && fone.length > 3) {
      let digito = fone.substring(3, 2);
      if (digito == 9) {
        return '(00) 00000-0000';
      } else {
        return '(00) 0000-0000';
      }
    }
  }

  getMoeda(valor: number) : string {
    return valor.toLocaleString('pt-BR', {'currency': 'BRL', 'minimumFractionDigits': 2});
  }

  

}