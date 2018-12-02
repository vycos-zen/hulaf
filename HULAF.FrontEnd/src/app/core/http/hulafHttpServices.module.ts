import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { LocationService } from '@httpServices/location-service/location-service';
import { PersonService, } from '@httpServices/person-service/person-service';


@NgModule({
    imports: [
        HttpModule,
    ],
    providers: [
        PersonService,
        LocationService
    ],
    exports: [
    ]
})
export class HulafHttpServiceModule {

    public PersonService: PersonService;

    public LocationService: LocationService;

    constructor(personService: PersonService, locationService: LocationService) {
        this.PersonService = personService;
        this.LocationService = locationService;
    }
}
