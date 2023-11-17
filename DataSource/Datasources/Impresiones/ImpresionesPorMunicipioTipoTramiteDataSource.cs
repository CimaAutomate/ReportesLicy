using DataSource.DatasourceModels;


namespace DataSource.Datasources.Impresiones
{
    public class ImpresionesPorMunicipioTipoTramiteDataSource
    {
        public List<ImpresionesPorMunicipioTipoTramite> GetImpresionesPorMunicipioTipoTramite(DateTime startDate, DateTime endDate, int municipioID, int tipoTramiteID)
        {
           return GetDummyData();
        }

        private List<ImpresionesPorMunicipioTipoTramite> GetDummyData()
        {
            return new List<ImpresionesPorMunicipioTipoTramite>()
            {
                new ImpresionesPorMunicipioTipoTramite() {Municipio = "Municipio 1", TipoTramite = "Tramite 1", Impresiones = 10},
                new ImpresionesPorMunicipioTipoTramite() {Municipio = "Municipio 1", TipoTramite = "Tramite 2", Impresiones = 20},
                new ImpresionesPorMunicipioTipoTramite() {Municipio = "Municipio 1", TipoTramite = "Tramite 3", Impresiones = 30},
                new ImpresionesPorMunicipioTipoTramite() {Municipio = "Municipio 2", TipoTramite = "Tramite 1", Impresiones = 40},
                new ImpresionesPorMunicipioTipoTramite() {Municipio = "Municipio 2", TipoTramite = "Tramite 2", Impresiones = 50},
                new ImpresionesPorMunicipioTipoTramite() {Municipio = "Municipio 2", TipoTramite = "Tramite 3", Impresiones = 60},
                new ImpresionesPorMunicipioTipoTramite() {Municipio = "Municipio 3", TipoTramite = "Tramite 1", Impresiones = 70},
                new ImpresionesPorMunicipioTipoTramite() {Municipio = "Municipio 3", TipoTramite = "Tramite 2", Impresiones = 80},
                new ImpresionesPorMunicipioTipoTramite() {Municipio = "Municipio 3", TipoTramite = "Tramite 3", Impresiones = 90},

            };
        }
    }
}
