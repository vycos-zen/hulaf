import { NgModule, APP_INITIALIZER, } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HulafServiceModule } from '../core/http/hulafServices.module';
import { HttpClientModule } from '@angular/common/http';
// import { TranslateService } from './translate/translate.service';

import { AppRoutingModule } from './routing/app-routing.module';

import { HomeModule } from '../modules/home/home.module';
import { LocatorModule } from '../modules/locator/locator.module';
import { SubmiterModule } from '../modules/submiter/submiter.module';
import { TranslatePipe } from './translate/translate.pipe';
import { RouterModule } from '@angular/router';


// export function setupTranslateFactory(
//   service: TranslateService): Function {
//   return () => service.use('en');
// }

@NgModule({
  imports: [
    CommonModule,
    AppRoutingModule,
    HttpClientModule,
    HulafServiceModule,
    HomeModule,
    LocatorModule,
    SubmiterModule
  ],
  exports: [
    RouterModule
  ],

  providers: [
    // TranslateService,
    // {
    //   provide: APP_INITIALIZER,
    //   useFactory: setupTranslateFactory,
    //   deps: [TranslateService],
    //   multi: true
    // }
  ],
  declarations: [
    TranslatePipe,
  ],
})
export class CoreModule { }
