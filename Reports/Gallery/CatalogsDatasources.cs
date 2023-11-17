using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;

namespace Reports.Gallery
{
    public class CatalogsDatasources
    {
        private XtraReport _report;
        public ObjectConstructorInfo constructorInfo;
        public CatalogsDatasources(XtraReport report, ObjectConstructorInfo constructorInfo)
        {
            this._report = report;
            this.constructorInfo = constructorInfo;
        }

        public ObjectDataSource MunicipiosCatalog;

        public CatalogsDatasources AddMunicipios()
        {
            MunicipiosCatalog = new ObjectDataSource(_report.Container);
            ((System.ComponentModel.ISupportInitialize)(MunicipiosCatalog)).BeginInit();
            MunicipiosCatalog.Constructor = constructorInfo;
            MunicipiosCatalog.DataMember = "GetAll";
            MunicipiosCatalog.DataSource = typeof(global::DataSource.Repositories.MunicipiosRepository);
            MunicipiosCatalog.Name = "MunicipiosCatalog";

            return this;
        }

    }

}

