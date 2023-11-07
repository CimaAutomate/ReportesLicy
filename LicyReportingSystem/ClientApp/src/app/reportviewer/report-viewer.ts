import { AfterViewInit, Component, Inject, ViewChild, ViewEncapsulation } from '@angular/core';
import { DxReportViewerComponent, DxReportViewerTabPanelSettingsComponent } from 'devexpress-reporting-angular';

import { environment } from '../../environments/environment';


@Component({
  selector: 'report-viewer',
  encapsulation: ViewEncapsulation.None,
  templateUrl: './report-viewer.html',
  styleUrls: [
    "../../../node_modules/devextreme/dist/css/dx.material.blue.light.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.common.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.material.blue.light.css",
    "../../../node_modules/devexpress-reporting/dist/css/dx-webdocumentviewer.css"
  ]
})
export class ReportViewerComponent implements AfterViewInit {

    @ViewChild(DxReportViewerTabPanelSettingsComponent) tabPanel: DxReportViewerTabPanelSettingsComponent;


    reportUrl: string = "ImpresionesPorMunicipioReport";
    invokeAction: string = '/DXXRDV';
    hostUrl:string
    

    constructor() {
        this.hostUrl = environment.API_URL

    }

    ngAfterViewInit() {


    }

    public BeforeRender(s, e) {
        var previewModel = s.GetPreviewModel();
        previewModel.tabPanel.collapsed(false);
        previewModel.tabPanel.tabs[0].active(true);
    }
}