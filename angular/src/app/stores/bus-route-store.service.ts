import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { BaseApiUrl } from "../util/api-util";
import { BusRoute } from "../models/bus-route";

@Injectable()
export class BusRouteStore {

  static BASE_URL = `${BaseApiUrl}api/busroute/`;
  static CREATE_URL = `${BusRouteStore.BASE_URL}create`;  


  constructor(private http: HttpClient) {

  }


  find(): Promise<BusRoute[]> {
    return this.http.get(BusRouteStore.BASE_URL)
      .toPromise()
      .then(r => r as BusRoute[]);
  }

}