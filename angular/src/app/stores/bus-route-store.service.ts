import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { BaseApiUrl } from "../util/api-util";
import { BusRoute } from "../models/bus-route";
import { CreateBusRouteCommand } from "../commands/createBusRoute";

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


  create(cmd: CreateBusRouteCommand): Promise<BusRoute> {
    return this.http.post(BusRouteStore.CREATE_URL, cmd)
      .toPromise()
      .then(r => r as BusRoute);
  }

}