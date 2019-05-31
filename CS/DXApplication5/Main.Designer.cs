using DevExpress.DataAccess.UI;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;

namespace DXSample {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colInfo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTest = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colName,
            this.colInfo1,
            this.colState1,
            this.colSubData});
            this.gridView2.DetailHeight = 673;
            this.gridView2.FixedLineWidth = 4;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.MinWidth = 40;
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            this.colID1.Width = 150;
            // 
            // colName
            // 
            this.colName.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 40;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 150;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colInfo1
            // 
            this.colInfo1.FieldName = "Info";
            this.colInfo1.MinWidth = 40;
            this.colInfo1.Name = "colInfo1";
            this.colInfo1.Visible = true;
            this.colInfo1.VisibleIndex = 2;
            this.colInfo1.Width = 150;
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.MinWidth = 40;
            this.colState1.Name = "colState1";
            this.colState1.Visible = true;
            this.colState1.VisibleIndex = 3;
            this.colState1.Width = 150;
            // 
            // colSubData
            // 
            this.colSubData.FieldName = "SubData";
            this.colSubData.MinWidth = 40;
            this.colSubData.Name = "colSubData";
            this.colSubData.Visible = true;
            this.colSubData.VisibleIndex = 4;
            this.colSubData.Width = 150;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.recordBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Location = new System.Drawing.Point(0, 274);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1});
            this.gridControl1.Size = new System.Drawing.Size(2032, 1041);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataSource = typeof(DXSample.Record);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colParentID,
            this.colText,
            this.colInfo,
            this.colValue,
            this.colDate,
            this.colState,
            this.colImage,
            this.colDetail,
            this.colTest});
            this.gridView1.DetailHeight = 673;
            this.gridView1.FixedLineWidth = 4;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barCheckItem1,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(2032, 274);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Toggle Draw Mode";
            this.barCheckItem1.Id = 1;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 2;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barCheckItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 40;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 150;
            // 
            // colParentID
            // 
            this.colParentID.FieldName = "ParentID";
            this.colParentID.MinWidth = 40;
            this.colParentID.Name = "colParentID";
            this.colParentID.Visible = true;
            this.colParentID.VisibleIndex = 1;
            this.colParentID.Width = 150;
            // 
            // colText
            // 
            this.colText.FieldName = "Text";
            this.colText.MinWidth = 40;
            this.colText.Name = "colText";
            this.colText.Visible = true;
            this.colText.VisibleIndex = 2;
            this.colText.Width = 150;
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "Info";
            this.colInfo.MinWidth = 40;
            this.colInfo.Name = "colInfo";
            this.colInfo.Visible = true;
            this.colInfo.VisibleIndex = 3;
            this.colInfo.Width = 150;
            // 
            // colValue
            // 
            this.colValue.FieldName = "Value";
            this.colValue.MinWidth = 40;
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 4;
            this.colValue.Width = 150;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 40;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 5;
            this.colDate.Width = 150;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.MinWidth = 40;
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 6;
            this.colState.Width = 150;
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.MinWidth = 40;
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 7;
            this.colImage.Width = 150;
            // 
            // colDetail
            // 
            this.colDetail.FieldName = "Detail";
            this.colDetail.MinWidth = 40;
            this.colDetail.Name = "colDetail";
            this.colDetail.Visible = true;
            this.colDetail.VisibleIndex = 8;
            this.colDetail.Width = 150;
            // 
            // colTest
            // 
            this.colTest.FieldName = "Test";
            this.colTest.MinWidth = 40;
            this.colTest.Name = "colTest";
            this.colTest.Visible = true;
            this.colTest.VisibleIndex = 9;
            this.colTest.Width = 150;
            // 
            // Main
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2032, 1315);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.BindingSource recordBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo1;
        private DevExpress.XtraGrid.Columns.GridColumn colState1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubData;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colParentID;
        private DevExpress.XtraGrid.Columns.GridColumn colText;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colTest;
    }
}