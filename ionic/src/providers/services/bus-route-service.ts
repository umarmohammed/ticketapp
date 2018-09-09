import { Injectable } from '@angular/core';
import { BusRoute } from '../../models/bus-route';
import { BusRouteStore } from '../stores/bus-route-store';

/*
  Generated class for the BusRouteServiceProvider provider.

  See https://angular.io/guide/dependency-injection for more info on providers
  and Angular DI.
*/
@Injectable()
export class BusRouteService {

  constructor(private busRouteStore: BusRouteStore) {
  }


  find(): Promise<BusRoute[]> {
    return this.busRouteStore.find();
  }

}
