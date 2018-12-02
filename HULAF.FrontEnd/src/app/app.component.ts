import { Component } from '@angular/core';
import {TranslateService} from '@ngx-translate/core';
// import { AppSettings } from './core/app-settings.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less']
})

export class AppComponent {
  todaysDate = Date.now();
  availableLanuages = [
    { lang: 'en', string: 'EN' },
    { lang: 'hu', string: 'HU' },
  ];

  translate: TranslateService;

  constructor(translate: TranslateService) {
    this.translate = translate;
    this.translate.setDefaultLang('en');
  }
  setLang(lang: string) {
    this.translate.use(lang);
  }
}
