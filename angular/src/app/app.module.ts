import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { BusRouteListComponent } from './pages/bus-route-list/bus-route-list.component';

import { BusRouteService } from './services/bus-route.service';
import { BusRouteStore } from './stores/bus-route-store.service';

import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { CreateBusRouteComponent } from './pages/create-bus-route/create-bus-route.component';

@NgModule({
  declarations: [
    AppComponent,
    BusRouteListComponent,
    CreateBusRouteComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    BusRouteService,
    BusRouteStore
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
