Imports DevExpress.DataAccess.UI
Imports DevExpress.Utils.MVVM
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns

Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			Me.colInfo1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colState1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSubData = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
			Me.skinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colParentID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colText = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colInfo = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDetail = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTest = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID1, Me.colName, Me.colInfo1, Me.colState1, Me.colSubData})
			Me.gridView2.DetailHeight = 673
			Me.gridView2.FixedLineWidth = 4
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' colID1
			' 
			Me.colID1.FieldName = "ID"
			Me.colID1.MinWidth = 40
			Me.colID1.Name = "colID1"
			Me.colID1.Visible = True
			Me.colID1.VisibleIndex = 0
			Me.colID1.Width = 150
			' 
			' colName
			' 
			Me.colName.ColumnEdit = Me.repositoryItemMemoExEdit1
			Me.colName.FieldName = "Name"
			Me.colName.MinWidth = 40
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 1
			Me.colName.Width = 150
			' 
			' repositoryItemMemoExEdit1
			' 
			Me.repositoryItemMemoExEdit1.AutoHeight = False
			Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
			' 
			' colInfo1
			' 
			Me.colInfo1.FieldName = "Info"
			Me.colInfo1.MinWidth = 40
			Me.colInfo1.Name = "colInfo1"
			Me.colInfo1.Visible = True
			Me.colInfo1.VisibleIndex = 2
			Me.colInfo1.Width = 150
			' 
			' colState1
			' 
			Me.colState1.FieldName = "State"
			Me.colState1.MinWidth = 40
			Me.colState1.Name = "colState1"
			Me.colState1.Visible = True
			Me.colState1.VisibleIndex = 3
			Me.colState1.Width = 150
			' 
			' colSubData
			' 
			Me.colSubData.FieldName = "SubData"
			Me.colSubData.MinWidth = 40
			Me.colSubData.Name = "colSubData"
			Me.colSubData.Visible = True
			Me.colSubData.VisibleIndex = 4
			Me.colSubData.Width = 150
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.recordBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6)
			Me.gridControl1.Location = New System.Drawing.Point(0, 274)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Margin = New System.Windows.Forms.Padding(6)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoExEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(2032, 1041)
			Me.gridControl1.TabIndex = 2
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' recordBindingSource
			' 
			Me.recordBindingSource.DataSource = GetType(DXSample.Record)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colParentID, Me.colText, Me.colInfo, Me.colValue, Me.colDate, Me.colState, Me.colImage, Me.colDetail, Me.colTest})
			Me.gridView1.DetailHeight = 673
			Me.gridView1.FixedLineWidth = 4
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.barCheckItem1, Me.skinRibbonGalleryBarItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(6)
			Me.ribbonControl1.MaxItemId = 3
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.Size = New System.Drawing.Size(2032, 274)
			' 
			' barCheckItem1
			' 
			Me.barCheckItem1.Caption = "Toggle Draw Mode"
			Me.barCheckItem1.Id = 1
			Me.barCheckItem1.Name = "barCheckItem1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
			' 
			' skinRibbonGalleryBarItem1
			' 
			Me.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1"
			Me.skinRibbonGalleryBarItem1.Id = 2
			Me.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barCheckItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.skinRibbonGalleryBarItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' colID
			' 
			Me.colID.FieldName = "ID"
			Me.colID.MinWidth = 40
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			Me.colID.Width = 150
			' 
			' colParentID
			' 
			Me.colParentID.FieldName = "ParentID"
			Me.colParentID.MinWidth = 40
			Me.colParentID.Name = "colParentID"
			Me.colParentID.Visible = True
			Me.colParentID.VisibleIndex = 1
			Me.colParentID.Width = 150
			' 
			' colText
			' 
			Me.colText.FieldName = "Text"
			Me.colText.MinWidth = 40
			Me.colText.Name = "colText"
			Me.colText.Visible = True
			Me.colText.VisibleIndex = 2
			Me.colText.Width = 150
			' 
			' colInfo
			' 
			Me.colInfo.FieldName = "Info"
			Me.colInfo.MinWidth = 40
			Me.colInfo.Name = "colInfo"
			Me.colInfo.Visible = True
			Me.colInfo.VisibleIndex = 3
			Me.colInfo.Width = 150
			' 
			' colValue
			' 
			Me.colValue.FieldName = "Value"
			Me.colValue.MinWidth = 40
			Me.colValue.Name = "colValue"
			Me.colValue.Visible = True
			Me.colValue.VisibleIndex = 4
			Me.colValue.Width = 150
			' 
			' colDate
			' 
			Me.colDate.FieldName = "Date"
			Me.colDate.MinWidth = 40
			Me.colDate.Name = "colDate"
			Me.colDate.Visible = True
			Me.colDate.VisibleIndex = 5
			Me.colDate.Width = 150
			' 
			' colState
			' 
			Me.colState.FieldName = "State"
			Me.colState.MinWidth = 40
			Me.colState.Name = "colState"
			Me.colState.Visible = True
			Me.colState.VisibleIndex = 6
			Me.colState.Width = 150
			' 
			' colImage
			' 
			Me.colImage.FieldName = "Image"
			Me.colImage.MinWidth = 40
			Me.colImage.Name = "colImage"
			Me.colImage.Visible = True
			Me.colImage.VisibleIndex = 7
			Me.colImage.Width = 150
			' 
			' colDetail
			' 
			Me.colDetail.FieldName = "Detail"
			Me.colDetail.MinWidth = 40
			Me.colDetail.Name = "colDetail"
			Me.colDetail.Visible = True
			Me.colDetail.VisibleIndex = 8
			Me.colDetail.Width = 150
			' 
			' colTest
			' 
			Me.colTest.FieldName = "Test"
			Me.colTest.MinWidth = 40
			Me.colTest.Name = "colTest"
			Me.colTest.Visible = True
			Me.colTest.VisibleIndex = 9
			Me.colTest.Width = 150
			' 
			' Main
			' 
			Me.Appearance.BackColor = System.Drawing.SystemColors.Control
			Me.Appearance.Options.UseBackColor = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(12F, 25F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(2032, 1315)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Margin = New System.Windows.Forms.Padding(6)
			Me.Name = "Main"
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		Private recordBindingSource As System.Windows.Forms.BindingSource
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents barCheckItem1 As DevExpress.XtraBars.BarCheckItem
		Private skinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colInfo1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colState1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colSubData As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colParentID As DevExpress.XtraGrid.Columns.GridColumn
		Private colText As DevExpress.XtraGrid.Columns.GridColumn
		Private colInfo As DevExpress.XtraGrid.Columns.GridColumn
		Private colValue As DevExpress.XtraGrid.Columns.GridColumn
		Private colDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colState As DevExpress.XtraGrid.Columns.GridColumn
		Private colImage As DevExpress.XtraGrid.Columns.GridColumn
		Private colDetail As DevExpress.XtraGrid.Columns.GridColumn
		Private colTest As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace