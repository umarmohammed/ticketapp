import { RouterModule, Routes } from '@angular/router'
import { BusRouteListComponent } from './pages/bus-route-list/bus-route-list.component';
import { NgModule } from '@angular/core';
import { CreateBusRouteComponent } from './pages/create-bus-route/create-bus-route.component';

const appRoutes: Routes = [
  { path: 'busroutes', component: BusRouteListComponent },
  { path: 'create', component: CreateBusRouteComponent },
  { path: '', redirectTo: '/busroutes', pathMatch: 'full'}
];

@NgModule({
  imports: [
    RouterModule.forRoot(
      appRoutes,
      {enableTracing: false }
    )
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {}