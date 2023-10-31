using DevExpress.AspNetCore.Reporting.QueryBuilder;
using DevExpress.AspNetCore.Reporting.ReportDesigner;
using DevExpress.AspNetCore.Reporting.ReportDesigner.Native.Services;
using DevExpress.AspNetCore.Reporting.QueryBuilder.Native.Services;
using DevExpress.XtraReports.Web.ReportDesigner;
using DevExpress.XtraReports.Web.ReportDesigner.Services;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using DataSource.Datasources.Impresiones;

namespace LicyReportingSystem.Controllers {

    public class CustomWebDocumentViewerController : WebDocumentViewerController {


        public CustomWebDocumentViewerController(
            IWebDocumentViewerMvcControllerService controllerService) : base(controllerService) {

        }


    }
    public class CustomReportDesignerController : ReportDesignerController {
        public CustomReportDesignerController(IReportDesignerMvcControllerService controllerService) : base(controllerService) {
        }

        [HttpPost("[action]")]
        public IActionResult GetDesignerModel([FromForm]string reportUrl, [FromServices] IReportDesignerModelBuilder designerModelBuilder, [FromForm] ReportDesignerSettingsBase designerModelSettings) {

            var designerModel = designerModelBuilder.Report(reportUrl)
                .BuildModel();
           designerModel.Assign(designerModelSettings);
           return DesignerModel(designerModel);
        }
    }

    public class CustomQueryBuilderController : QueryBuilderController {
        public CustomQueryBuilderController(IQueryBuilderMvcControllerService controllerService) : base(controllerService) {

        }
    }


}