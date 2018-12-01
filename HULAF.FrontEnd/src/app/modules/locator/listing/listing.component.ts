import { Component, OnInit } from '@angular/core';
import { LocationService, CountryDto } from 'src/app/core/http/location-service/location-service';

@Component({
  selector: 'app-listing',
  templateUrl: './listing.component.html',
  styleUrls: ['./listing.component.less']
})
export class ListingComponent implements OnInit {

  public countries: CountryDto[];


  constructor(locationServie: LocationService) {
    locationServie.getCountryList().subscribe(result => {
      this.countries = result;
    });

  }
  ngOnInit() {
  }

}
