import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LogowanieComponent } from './logowanie/logowanie.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { MenuComponent } from './menu/menu.component';

const routes: Routes = [
  {path: '', component: LogowanieComponent},
  {path: 'dashboard', component: DashboardComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
