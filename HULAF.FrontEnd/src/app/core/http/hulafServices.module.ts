import { NgModule } from '@angular/core';
import { HttpModule} from '@angular/http';
import {  LocationService } from './location-service/location-service';

@NgModule({
    imports: [
        HttpModule,
    ],
    providers: [
        LocationService
    ],
})
export class HulafServiceModule {

}
