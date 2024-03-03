import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LogowanieComponent } from './logowanie/logowanie.component';

const routes: Routes = [
  {path: 'logowanie', component: LogowanieComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
