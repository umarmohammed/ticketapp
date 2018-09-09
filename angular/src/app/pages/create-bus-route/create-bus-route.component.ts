import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';

import { BusRouteService } from '../../services/bus-route.service';


@Component({
  selector: 'app-create-bus-route',
  templateUrl: './create-bus-route.component.html',
  styleUrls: ['./create-bus-route.component.scss']
})
export class CreateBusRouteComponent implements OnInit {

  busRouteForm = this.fb.group({
    name: [],
    price: []
  });


  constructor(private fb: FormBuilder,
    private busRouteService: BusRouteService,
    private router: Router) {

  }


  ngOnInit() {
  }


  onSubmit() {
    this.busRouteService.create(this.busRouteForm.value)
      .then(r => this.router.navigate(['/busroutes']))
  }

}
