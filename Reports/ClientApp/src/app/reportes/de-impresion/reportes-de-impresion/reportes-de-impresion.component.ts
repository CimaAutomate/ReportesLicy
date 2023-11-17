import { Component } from '@angular/core';
import ReporteLink from '../../../Base/ReporteLink';

@Component({
  selector: 'app-reportes-de-impresion',
  templateUrl: './reportes-de-impresion.component.html',
  styleUrls: ['./reportes-de-impresion.component.css']
})
export class ReportesDeImpresionComponent {
  reportsParentRoute:string = '/impresion';
  reportes:ReporteLink[] = [
    new ReporteLink('ImpresionesPorMunicipioReport', 'Por municipio'), 
    new ReporteLink('ImpresionesPorMunicipioFechaReport', 'Por municipio y fecha'),
    new ReporteLink('ImpresionesPorMunicipioTipoTramiteReport', 'Por municipio y tipo'), 
    new ReporteLink('ImpresionesPorMunicipioFechaTipoReport', 'Por municipio, fecha y tipo'),
    new ReporteLink('ImpresionesMunicipioTipoLicenciaFecha',  'Municipio, licencia y fecha'),
    new ReporteLink('ImpresionesMunicipioSexoFechaReport', 'Municipio, género y fecha'),
<<<<<<< HEAD
    new ReporteLink('ImpresionesPorCapturistaReport', 'Por capturista'),
=======
    new ReporteLink('ImpresionesMunicipioVigenciaFechaReport', 'Municipio, vigencia y fecha'),
>>>>>>> d3e059d75a9ac11913e3828204b553a7e3996c9f
  ];
}
