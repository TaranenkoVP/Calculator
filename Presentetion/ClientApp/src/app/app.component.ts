import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})

export class AppComponent {
  title = 'app';
  public parameter1 = 0;
  public parameter2 = 0;
  public result = 0;
  public selectedType;

  constructor(private http: HttpClient) { }

  public operationTypes: OperationTypes[] =
  [
      {
        data: "addition", symbol: "+"
      },
      {
        data: "Substract", symbol: "-"
      },
      {
        data: "multiply", symbol: "*"
      }
    ];


  public calculate() {

    const baseUrlToApi = "https://localhost:44397";
    let type = this.operationTypes.filter(type => type.symbol === this.selectedType)[0];
    let url = baseUrlToApi + "/api/Math/calculate?operationType=" + type.data + "&parameter1=" + this.parameter1 + "&parameter2=" + this.parameter2;

    this.http.get<OperationResult>(url).subscribe(result => {
      this.result = result.result;
    }, error => console.error(error));
  }
}

interface OperationResult {
  result: number;
}

interface OperationTypes {
  data: string;
  symbol: string;
}
