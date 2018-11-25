import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListingComponent } from './listing/listing.component';
import { MissingPersonComponent } from './missing-person/missing-person.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [ListingComponent, MissingPersonComponent]
})
export class LocatorModule { }
