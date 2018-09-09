import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { BusRoute } from '../../models/bus-route';
import { BusRouteService } from '../../services/bus-route.service';
import { MatDialog } from '@angular/material';
import { CreateBusRouteComponent } from '../../dialogs/create-bus-route/create-bus-route.component';

@Component({
  selector: 'app-bus-route-list',
  templateUrl: './bus-route-list.component.html',
  styleUrls: ['./bus-route-list.component.scss']
})
export class BusRouteListComponent implements OnInit {

  busRoutes: BusRoute[] = [];

  constructor(private busRouteService: BusRouteService,
    private dialog: MatDialog) {

  }


  ngOnInit() {
    this.loadBusRoutes();
  }


  showCreate() {
    const dialogRef = this.dialog.open(CreateBusRouteComponent);
    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.loadBusRoutes();
      }
    })
  }

  
  private loadBusRoutes() {
    this.busRouteService.find()
      .then(r => this.busRoutes = r);
  }

}
