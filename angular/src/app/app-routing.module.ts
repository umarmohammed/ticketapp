import { RouterModule, Routes } from '@angular/router'
import { BusRouteListComponent } from './pages/bus-route-list/bus-route-list.component';
import { NgModule } from '@angular/core';
import { BusRouteComponent } from './pages/bus-route/bus-route.component';

const appRoutes: Routes = [
  { 
    path: 'busroutes', 
    component: BusRouteComponent,
    children: [
      { path: '', component: BusRouteListComponent }
    ]
  },
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