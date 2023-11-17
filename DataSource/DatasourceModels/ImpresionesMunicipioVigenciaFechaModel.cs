﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.DatasourceModels
{
    public class ImpresionesMunicipioVigenciaFechaModel
    {
        public string Municipio { get; set; }
        public int Impresiones { get; set; }
        public DateTime FechaDePago { get; set; }
        public DateTime FechaDeCaptura { get; set; }
        public int Anios { get; set; }
    }
}
