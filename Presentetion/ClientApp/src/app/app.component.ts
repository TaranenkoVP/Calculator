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
  public operationTypes: OperationTypes[] =
    [
      {
        data: "%2B", symbol: "+"
      },
      {
        data: "-", symbol: "-"
      },
      {
        data: "%2A", symbol: "*"
      },
      {
        data: "%2F", symbol: "/"
      }
    ];

  public selectedType = this.operationTypes[0].symbol;

  constructor(private http: HttpClient) { }

  public calculate() {
    const baseUrlToApi = "https://localhost:44397";
    let type = this.operationTypes.filter(type => type.symbol === this.selectedType)[0];
    let url = baseUrlToApi + "/api/Math/calculate?query=" + this.parameter1 + type.data + this.parameter2;

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
