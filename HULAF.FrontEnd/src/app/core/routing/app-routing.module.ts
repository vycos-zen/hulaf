import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {HomeComponent} from '../../modules/home/home/home.component';
import {ListingComponent} from '../../modules/locator/listing/listing.component';
import {SeekerComponent} from '../../modules/submiter/seeker/seeker.component';

const routes: Routes = [
  { path: '', component: HomeComponent},
  { path: 'listing', component: ListingComponent},
  { path: 'seeker', component: SeekerComponent},

];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
