Imports DevExpress.Data.Filtering
Imports System
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DXSample.CustomFunctions
Imports DevExpress.XtraEditors.Repository

Namespace DXSample
	Partial Public Class Main
		Inherits DevExpress.XtraEditors.XtraForm

		Private spinEdit As RepositoryItemSpinEdit
		Public Sub New()
			InitializeComponent()
			recordBindingSource.DataSource = DataHelper.GetData(100, 10)
			spinEdit = New RepositoryItemSpinEdit()
			spinEdit.IsFloatValue = False
			AddHandler gridView1.QueryCustomFunctions, AddressOf OnQueryCustomFunctions
			AddHandler gridView1.FilterEditorCreated, AddressOf OnFilterEditorCreated
			gridView1.OptionsView.FilterCriteriaDisplayStyle = DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Visual
			gridView1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.TextAndVisual
		End Sub
		Private Sub OnFilterEditorCreated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FilterControlEventArgs)
			'e.FilterEditor.InitNode += OnInitNode;
			'e.FilterEditor.PopupMenuShowing += OnPopupMenuShowing;
			AddHandler e.FilterEditor.BeforeShowValueEditor, AddressOf OnBeforeShowValueEditor
		End Sub

		Private Sub OnBeforeShowValueEditor(ByVal sender As Object, ByVal e As ShowValueEditorEventArgs)
			Dim node As ClauseNodeEx = TryCast(e.CurrentNode, ClauseNodeEx)
			If node IsNot Nothing AndAlso node.Property.Type Is GetType(Date) AndAlso Equals(node.FunctionType, IsDaysInterval.FunctionName) Then
				e.CustomRepositoryItem = spinEdit
			End If
		End Sub

		Private Sub OnInitNode(ByVal sender As Object, ByVal e As InitNodeEventArgs)
			If e.IsNewNode Then
				e.PropertyName = "Dt"
				e.SetOperation("IsWeekend")
			ElseIf e.PropertyType Is GetType(String) Then
				e.SetOperation(FunctionOperatorType.Contains)
			End If
		End Sub
		Private Sub OnPopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Filtering.PopupMenuShowingEventArgs)
			If e.MenuType = FilterControlMenuType.Clause Then
				Dim node As ClauseNode = TryCast(e.CurrentNode, ClauseNode)
				If node IsNot Nothing AndAlso node.Property.Type Is GetType(Date) Then
					e.Menu.Hide(ClauseType.Equals)
					e.Menu.Remove(ClauseType.DoesNotEqual)
					e.Menu.Hide(DevExpress.XtraEditors.Controls.StringId.FilterAdvancedDateTimeOperatorMenuCaption)
					Dim menuItem = e.Menu.Find(ClauseType.Between)
					menuItem.Caption = "Between A and B"
					'menuItem.ImageOptions.SvgImage = MySvgImage1;
				End If
			End If
		End Sub
		Private Sub OnQueryCustomFunctions(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomFunctionEventArgs)
			If e.PropertyType Is GetType(Date) Then
				e.Add(IsWeekendFunction.FunctionName)
				If e.IsFilterEditor Then
					e.Add(IsDaysInterval.FunctionName)
				End If
			End If
		End Sub
		Private Sub barCheckItem1_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barCheckItem1.CheckedChanged
			gridView1.OptionsView.FilterCriteriaDisplayStyle = If(barCheckItem1.Checked, DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Text, DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Visual)
		End Sub
	End Class
End Namespace


