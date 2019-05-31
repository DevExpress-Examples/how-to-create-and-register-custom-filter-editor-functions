using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DXSample.CustomFunctions;

namespace DXSample {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            IsWeekendFunction.Register();
            IsDaysInterval.Register();
            NotBeginsWithFunction.Register();
            CriteriaOperator.QueryCustomFunctions += OnQueryCustomUIFunctions;
            UserLookAndFeel.Default.SkinName = "The Bezier";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            
        }
        private static void OnQueryCustomUIFunctions(object sender, DevExpress.Data.Filtering.CustomFunctionEventArgs e) {
            //if(e.PropertyType == typeof(string)) {
            //    e.Add(NotBeginsWithFunction.FunctionName);
            //}
        }
    }
}