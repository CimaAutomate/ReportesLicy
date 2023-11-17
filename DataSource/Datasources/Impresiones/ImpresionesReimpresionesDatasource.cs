using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.DatasourceModels
{
    public class ImpresionesReimpresionesDatasource
    {
        public List<ImpresionesReimpresionesModel> GetImpresionesReimpresiones(int moduloImpresionID, int moduloTramiteID, int tipoID)
        {
          return GetDummyData();
        }

        private List<ImpresionesReimpresionesModel> GetDummyData()
        {
            return new List<ImpresionesReimpresionesModel>
            {
                new ImpresionesReimpresionesModel
                {
                    ModuloTramite = "Modulo Tramite 1",
                    Capturista = "Capturista 1",
                    ModuloImpresion = "Modulo Impresion 1",
                    UsuarioImpresion = "Usuario Impresion 1",
                    Fecha = DateTime.Now,
                    Tipo = "Tipo 1",
                    Folio = "Folio 1",
                    NumeroLicencia = "Numero Licencia 1",
                    Motivo = "Motivo 1"
                },
                new ImpresionesReimpresionesModel
                {
                    ModuloTramite = "Modulo Tramite 1",
                    Capturista = "Capturista 2",
                    ModuloImpresion = "Modulo Impresion 2",
                    UsuarioImpresion = "Usuario Impresion 2",
                    Fecha = DateTime.Now,
                    Tipo = "Tipo 2",
                    Folio = "Folio 2",
                    NumeroLicencia = "Numero Licencia 2",
                    Motivo = "Motivo 2"
                },
                new ImpresionesReimpresionesModel
                {
                    ModuloTramite = "Modulo Tramite 2",
                    Capturista = "Capturista 3",
                    ModuloImpresion = "Modulo Impresion 3",
                    UsuarioImpresion = "Usuario Impresion 3",
                    Fecha = DateTime.Now,
                    Tipo = "Tipo 3",
                    Folio = "Folio 3",
                    NumeroLicencia = "Numero Licencia 3",
                    Motivo = "Motivo 3"
                },
                new ImpresionesReimpresionesModel
                {
                    ModuloTramite = "Modulo Tramite 2",
                    Capturista = "Capturista 4",
                    ModuloImpresion = "Modulo Impresion 4",
                    UsuarioImpresion = "Usuario Impresion 4",
                    Fecha = DateTime.Now,
                    Tipo = "Tipo 4",
                    Folio = "Folio 4",
                    NumeroLicencia = "Numero Licencia 4",
                    Motivo = "Motivo 4"
                },
                new ImpresionesReimpresionesModel
                {
                    ModuloTramite = "Modulo Tramite 1",
                    Capturista = "Capturista 1",
                    ModuloImpresion = "Modulo Impresion 2",
                    UsuarioImpresion = "Usuario Impresion 1",
                    Fecha = DateTime.Now,
                    Tipo = "Tipo 1",
                    Folio = "Folio 1",
                    NumeroLicencia = "Numero Licencia 1",
                    Motivo = "Motivo 1"
                },
                new ImpresionesReimpresionesModel
                {
                    ModuloTramite = "Modulo Tramite 1",
                    Capturista = "Capturista 2",
                    ModuloImpresion = "Modulo Impresion 2",
                    UsuarioImpresion = "Usuario Impresion 2",
                    Fecha = DateTime.Now,
                    Tipo = "Tipo 2",
                    Folio = "Folio 2",
                    NumeroLicencia = "Numero Licencia 2",
                    Motivo = "Motivo 2"
                },
                new ImpresionesReimpresionesModel
                {
                    ModuloTramite = "Modulo Tramite 2",
                    Capturista = "Capturista 3",
                    ModuloImpresion = "Modulo Impresion 3",
                    UsuarioImpresion = "Usuario Impresion 3",
                    Fecha = DateTime.Now,
                    Tipo = "Tipo 3",
                    Folio = "Folio 3",
                    NumeroLicencia = "Numero Licencia 3",
                    Motivo = "Motivo 3"
                },
                new ImpresionesReimpresionesModel
                {
                    ModuloTramite = "Modulo Tramite 2",
                    Capturista = "Capturista 4",
                    ModuloImpresion = "Modulo Impresion 4",
                    UsuarioImpresion = "Usuario Impresion 4",
                    Fecha = DateTime.Now,
                    Tipo = "Tipo 4",
                    Folio = "Folio 4",
                    NumeroLicencia = "Numero Licencia 4",
                    Motivo = "Motivo 4"
                },


            };

        }
    }
}
