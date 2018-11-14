import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  public tablaPrueba: TablaPrueba;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));

    http.get<TablaPrueba[]>(baseUrl + 'api/SampleData/MetodoPrueba').subscribe(result => {
      console.log(result[0]);
      this.tablaPrueba = result[0];
    }, error => console.error(error));

  }
}

interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

interface TablaPrueba {
  jefitaID: number;
  jefita: string;
  tieneEstetica: boolean;
}
