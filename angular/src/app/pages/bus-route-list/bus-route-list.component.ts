import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { BusRoute } from '../../models/bus-route';
import { BusRouteService } from '../../services/bus-route.service';

@Component({
  selector: 'app-bus-route-list',
  templateUrl: './bus-route-list.component.html',
  styleUrls: ['./bus-route-list.component.scss']
})
export class BusRouteListComponent implements OnInit {

  busRoutes: BusRoute[] = [];

  constructor(private busRouteService: BusRouteService) {

  }


  ngOnInit() {
    this.loadBusRoutes();
  }

  
  private loadBusRoutes() {
    this.busRouteService.find()
      .then(r => this.busRoutes = r);
  }

}
