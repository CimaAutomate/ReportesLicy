import { Component, Inject, Input, ViewEncapsulation } from '@angular/core';
import { environment } from '../../environments/environment';
import { ActivatedRoute, Router } from '@angular/router';
import ReporteLink from '../Base/ReporteLink';


import deMessages from "devextreme/localization/messages/es.json";
import { locale, loadMessages } from "devextreme/localization";



@Component({
  selector: 'report-viewer',
  encapsulation: ViewEncapsulation.None,
  templateUrl: './report-viewer.html',
  styleUrls: [
    "../../../node_modules/devextreme/dist/css/dx.material.blue.light.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.common.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.material.blue.light.css",
    "../../../node_modules/devexpress-reporting/dist/css/dx-webdocumentviewer.css",
    './report-viewer.css'
  ]
})
export class ReportViewerComponent {
  selectedReport: ReporteLink;
  invokeAction: string = '/DXXRDV';
  hostUrl:string
  @Input() reportes: ReporteLink[] = [];
  @Input() reportsParentRoute:string;
  @Input() title:string;


    constructor(@Inject('BASE_URL') hostUrl: string, private route: ActivatedRoute, private router: Router) {
        this.hostUrl = environment.API_URL;
        //this.hostUrl = hostUrl;
        console.log(this.hostUrl);

        loadMessages(deMessages);
        locale(navigator.language);
    }


  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      let reportUrl = params.get('reporte');
      
      this.selectedReport = this.reportes.find(x => x.link == reportUrl);

      console.log('report viewer init 2');
      if (!this.selectedReport) {
        this.navigateToDefault();
      }
    });
  }

  private navigateToDefault() {
    console.log('navigating to default');
    this.router.navigate([this.reportsParentRoute, this.reportes[0].link]);
  }

}

