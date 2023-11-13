import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { DxReportViewerModule, DxReportDesignerModule } from 'devexpress-reporting-angular';
import { ReportViewerComponent } from './reportviewer/report-viewer';
import { ReportesDeImpresionComponent } from './reportes/de-impresion/reportes-de-impresion/reportes-de-impresion.component';
import { DxDrawerModule, DxListModule, DxToolbarModule } from 'devextreme-angular';

 

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ReportViewerComponent,
    ReportesDeImpresionComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    DxReportViewerModule,
    DxDrawerModule,
    DxListModule,
    DxToolbarModule,
    RouterModule.forRoot([
      { path: '', redirectTo: '/impresion', pathMatch: 'full' },
      {
        path: 'impresion/:reporte', component: ReportesDeImpresionComponent
      },
      {
        path: 'impresion', component: ReportesDeImpresionComponent
      }
    ])
  ],

  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }