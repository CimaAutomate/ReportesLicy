import { Component } from '@angular/core';
import ReporteLink from '../../../Base/ReporteLink';

@Component({
  selector: 'app-reportes-de-impresion',
  templateUrl: './reportes-de-impresion.component.html',
  styleUrls: ['./reportes-de-impresion.component.css']
})
export class ReportesDeImpresionComponent {
  reportsParentRoute:string = '/impresion';
  reportes:ReporteLink[] = [ new ReporteLink('ImpresionesPorMunicipioReport', 'Por municipio'), new ReporteLink('ImpresionesPorMunicipioFechaReport', 'Por municipio y fecha'), ];
}
