import { Injectable } from "@angular/core";
import { BusRouteStore } from "../stores/bus-route-store.service";
import { BusRoute } from "../models/bus-route";

@Injectable()
export class BusRouteService {

  constructor(private busRouteStore: BusRouteStore) {

  }


  find(): Promise<BusRoute[]> {
    return this.busRouteStore.find();
  }

}