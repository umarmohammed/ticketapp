import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { BaseApiUrl } from '../../constants';
import { BusRoute } from '../../models/bus-route';

/*
  Generated class for the BusRouteServiceProvider provider.

  See https://angular.io/guide/dependency-injection for more info on providers
  and Angular DI.
*/
@Injectable()
export class BusRouteStore {

  static BASE_URL = `${BaseApiUrl}api/busroute/`;
  static CREATE_URL = `${BusRouteStore.BASE_URL}create`;  


  constructor(public http: Http) {
  }


  find(): Promise<BusRoute[]> {
    return this.http.get(BusRouteStore.BASE_URL)
      .toPromise()
      .then(r => r.json() as BusRoute[]);
  }
  
}
