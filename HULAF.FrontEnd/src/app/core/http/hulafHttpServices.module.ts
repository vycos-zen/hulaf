import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
// import { HulafApiService } from '@httpServices/hulaf-api/hulaf-api-service';


@NgModule({
    imports: [
        HttpClientModule,
    ],
    providers: [
        // HulafApiService,
    ],
    exports: [
    ]
})
export class HulafHttpServiceModule {

    // public HulafApiService: HulafApiService;


   /*  constructor(hulafApiService: HulafApiService) {
        this.HulafApiService = hulafApiService;
    } */
}
