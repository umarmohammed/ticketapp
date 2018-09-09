import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';

import { BusRouteService } from '../../services/bus-route.service';
import { MatDialogRef } from '@angular/material';


@Component({
  selector: 'app-create-bus-route',
  templateUrl: './create-bus-route.component.html',
  styleUrls: ['./create-bus-route.component.scss']
})
export class CreateBusRouteComponent implements OnInit {

  busRouteForm = this.fb.group({
    name: ['', Validators.required],
    price: ['', Validators.required]
  });

  submitted: boolean;

  constructor(private dialogRef: MatDialogRef<CreateBusRouteComponent>,
    private fb: FormBuilder,
    private busRouteService: BusRouteService,
    private router: Router) {

  }


  ngOnInit() {
  }


  onSubmit() {
    this.submitted = true;
    if (!this.busRouteForm.valid) return;
    this.busRouteService.create(this.busRouteForm.value)
      .then(r => this.dialogRef.close(true))
  }

}
