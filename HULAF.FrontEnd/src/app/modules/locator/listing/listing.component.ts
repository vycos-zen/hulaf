import { Component, OnInit } from '@angular/core';
import { HulafHttpServiceModule } from '@httpServices/hulafHttpServices.module';
import { MissingPersonDto } from '@httpServices/person-service/person-service';
import { CountryDto } from '@httpServices/location-service/location-service';

@Component({
  selector: 'app-listing',
  templateUrl: './listing.component.html',
  styleUrls: ['./listing.component.less'],
  providers: [HulafHttpServiceModule]
})
export class ListingComponent implements OnInit {

  public countries: CountryDto[];
  public missingPersons: MissingPersonDto[];

  constructor(hulafHttpService: HulafHttpServiceModule) {
    hulafHttpService.PersonService.getMissingPersonList().subscribe(result => {
      this.missingPersons = result;
    });

    hulafHttpService.LocationService.getCountryList().subscribe(result => {
      this.countries = result;
    });

  }
  ngOnInit() {
  }

}
