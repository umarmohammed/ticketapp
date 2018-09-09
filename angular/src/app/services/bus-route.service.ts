import { Injectable } from "@angular/core";
import { BusRouteStore } from "../stores/bus-route-store.service";
import { BusRoute } from "../models/bus-route";
import { CreateBusRouteCommand } from "../commands/createBusRoute";

@Injectable()
export class BusRouteService {

  constructor(private busRouteStore: BusRouteStore) {

  }


  find(): Promise<BusRoute[]> {
    return this.busRouteStore.find();
  }


  create(cmd: CreateBusRouteCommand) : Promise<BusRoute> {
    return this.busRouteStore.create(cmd);
  }
  
}