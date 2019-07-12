Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Reflection
Imports System.Threading
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DXSample.CustomFunctions

Namespace DXSample
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			IsWeekendFunction.Register()
			IsDaysInterval.Register()
			NotBeginsWithFunction.Register()
			AddHandler CriteriaOperator.QueryCustomFunctions, AddressOf OnQueryCustomUIFunctions
			UserLookAndFeel.Default.SkinName = "The Bezier"
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Main())

		End Sub
		Private Sub OnQueryCustomUIFunctions(ByVal sender As Object, ByVal e As DevExpress.Data.Filtering.CustomFunctionEventArgs)
			'if(e.PropertyType == typeof(string)) {
			'    e.Add(NotBeginsWithFunction.FunctionName);
			'}
		End Sub
	End Module
End Namespace