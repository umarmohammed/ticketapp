import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { BusRoute } from '../../models/bus-route';
import { BusRouteService } from '../../providers/services/bus-route-service';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  busRoutes: BusRoute[] = []

  constructor(private busRouteService: BusRouteService,
    public navCtrl: NavController) {
      this.loadBusRoutes();
  }


  private loadBusRoutes() {
    this.busRouteService.find()
      .then(r => this.busRoutes = r);
  }

}
