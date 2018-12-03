import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { HulafApiService } from '@httpServices/hulaf-api/hulaf-api-service';


@NgModule({
    imports: [
        HttpModule,
    ],
    providers: [
        HulafApiService,
    ],
    exports: [
    ]
})
export class HulafHttpServiceModule {

    public HulafApiService: HulafApiService;


    constructor(hulafApiService: HulafApiService) {
        this.HulafApiService = hulafApiService;
    }
}
