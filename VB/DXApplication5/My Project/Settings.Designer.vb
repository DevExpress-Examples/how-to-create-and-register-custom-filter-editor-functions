﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


	<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")>
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property

		<Global.System.Configuration.ApplicationScopedSettingAttribute()>
		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
		<Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString)>
		<Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\SQLEXPRESS;Initial Catalog=northwind;Integrated Security=True")>
		Public ReadOnly Property northwindConnectionString() As String
			Get
				Return (DirectCast(Me("northwindConnectionString"), String))
			End Get
		End Property

		<Global.System.Configuration.ApplicationScopedSettingAttribute()>
		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
		<Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString)>
		<Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")>
		Public ReadOnly Property masterConnectionString() As String
			Get
				Return (DirectCast(Me("masterConnectionString"), String))
			End Get
		End Property

		<Global.System.Configuration.ApplicationScopedSettingAttribute()>
		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
		<Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString)>
		<Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Users\Public\Documents\DevExpres" & "s Demos 16.2\Components\Data\CarsDB.mdb""")>
		Public ReadOnly Property CarsDBConnectionString() As String
			Get
				Return (DirectCast(Me("CarsDBConnectionString"), String))
			End Get
		End Property
	End Class
End Namespace