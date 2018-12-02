import { NgModule } from '@angular/core';
import { SharedModule } from 'app/shared/shared.module';
import { SeekerComponent } from './seeker/seeker.component';

@NgModule({
  imports: [
    SharedModule,
  ],
  declarations: [SeekerComponent]
})
export class SubmiterModule { }
