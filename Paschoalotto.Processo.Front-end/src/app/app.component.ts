import { Component, Input } from '@angular/core';
import { CalculoService } from './calculo.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Paschoalotto.Processo.Front';
  @Input() btnText!: String

  constructor(private CalculoService :CalculoService)
  {}

  CalcularAcordo(divida:string,vencimento:string){
    this.CalculoService.CalcularAcordo(divida,vencimento)
    .then(calculofinal => console.log(calculofinal))
    .catch(error => console.error(error));

  }


}

