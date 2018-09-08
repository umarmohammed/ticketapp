import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BusRouteListComponent } from './pages/bus-route-list/bus-route-list.component';

import { BusRouteService } from './services/bus-route.service';
import { BusRouteStore } from './stores/bus-route-store.service';

import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    BusRouteListComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [
    BusRouteService,
    BusRouteStore
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
