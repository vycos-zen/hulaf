import { NgModule, APP_INITIALIZER } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListingComponent } from './listing/listing.component';
import { MissingPersonComponent } from './missing-person/missing-person.component';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    SharedModule
  ],
  providers: [
  ],
  declarations: [ListingComponent, MissingPersonComponent]
})
export class LocatorModule {
  constructor() {
  }
}
