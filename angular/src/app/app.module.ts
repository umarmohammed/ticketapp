import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { BusRouteListComponent } from './pages/bus-route-list/bus-route-list.component';

import { BusRouteService } from './services/bus-route.service';
import { BusRouteStore } from './stores/bus-route-store.service';

import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { MaterialModule } from './material/material.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BusRouteComponent } from './pages/bus-route/bus-route.component';

import { CreateBusRouteComponent } from './dialogs/create-bus-route/create-bus-route.component';

@NgModule({
  declarations: [
    AppComponent,
    BusRouteListComponent,
    CreateBusRouteComponent,
    BusRouteComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MaterialModule,
    AppRoutingModule,
    HttpClientModule
  ],
  entryComponents: [
    CreateBusRouteComponent
  ],
  providers: [
    BusRouteService,
    BusRouteStore
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
