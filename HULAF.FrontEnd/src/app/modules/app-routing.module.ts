import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {HomeComponent} from './home/home/home.component';
import {ListingComponent} from './locator/listing/listing.component';
import {SeekerComponent} from './submiter/seeker/seeker.component';

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
