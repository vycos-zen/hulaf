import { Component, OnInit } from '@angular/core';
import { HulafHttpServiceModule } from '@httpServices/hulafHttpServices.module';
import { MissingPersonDto , CountryDto} from '@httpServices/hulaf-api/hulaf-api-service';

@Component({
  selector: 'app-listing',
  templateUrl: './listing.component.html',
  styleUrls: ['./listing.component.less'],
  providers: [HulafHttpServiceModule]
})
export class ListingComponent implements OnInit {

  public countries: CountryDto[];
  public missingPersons: MissingPersonDto[];

  constructor(hulafHttpServiceModule: HulafHttpServiceModule) {

    hulafHttpServiceModule.HulafApiService.getMissingPersonList().subscribe(result => {
      this.missingPersons = result;
    });

    hulafHttpServiceModule.HulafApiService.getCountryList().subscribe(result => {
      this.countries = result;
    });

  }
  ngOnInit() {
  }

}
