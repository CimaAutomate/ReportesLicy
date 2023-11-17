using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Reports.PredefinedReports
{
    public static class ReportsFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>();

        static ReportsFactory()
        {
            Reports = GetAssemblyReports();
        }

        private static Dictionary<string, Func<XtraReport>> GetAssemblyReports()
        {
            var reports = new Dictionary<string, Func<XtraReport>>();
            var reportTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(XtraReport)));

            foreach (var type in reportTypes)
            {
                reports[type.Name] = () => (XtraReport)Activator.CreateInstance(type);
            }

            return reports;
        }
    }
}
