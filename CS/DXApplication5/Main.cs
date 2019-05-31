using DevExpress.Data.Filtering;
using System;
using DevExpress.XtraEditors.Filtering;
using DevExpress.Data.Filtering.Helpers;
using DXSample.CustomFunctions;
using DevExpress.XtraEditors.Repository;

namespace DXSample {
    public partial class Main : DevExpress.XtraEditors.XtraForm {
        RepositoryItemSpinEdit spinEdit;
        public Main() {
            InitializeComponent();
            recordBindingSource.DataSource = DataHelper.GetData(100, 10);
            spinEdit = new RepositoryItemSpinEdit();
            spinEdit.IsFloatValue = false;
            gridView1.QueryCustomFunctions += OnQueryCustomFunctions;
            gridView1.FilterEditorCreated += OnFilterEditorCreated;
            gridView1.OptionsView.FilterCriteriaDisplayStyle = DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Visual;
            gridView1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.TextAndVisual;
        }
        private void OnFilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e) {
            //e.FilterEditor.InitNode += OnInitNode;
            //e.FilterEditor.PopupMenuShowing += OnPopupMenuShowing;
            e.FilterEditor.BeforeShowValueEditor += OnBeforeShowValueEditor;
        }

        private void OnBeforeShowValueEditor(object sender, ShowValueEditorEventArgs e) {
            ClauseNodeEx node = e.CurrentNode as ClauseNodeEx;
            if(node != null && node.Property.Type == typeof(DateTime) && Equals(node.FunctionType, IsDaysInterval.FunctionName))
                e.CustomRepositoryItem = spinEdit;
        }

        private void OnInitNode(object sender, InitNodeEventArgs e) {
            if(e.IsNewNode) {
                e.PropertyName = "Dt";
                e.SetOperation("IsWeekend");
            }
            else if(e.PropertyType == typeof(string))
                e.SetOperation(FunctionOperatorType.Contains);
        }
        private void OnPopupMenuShowing(object sender, DevExpress.XtraEditors.Filtering.PopupMenuShowingEventArgs e) {
            if(e.MenuType == FilterControlMenuType.Clause){
                ClauseNode node = e.CurrentNode as ClauseNode;
                if (node != null && node.Property.Type == typeof(DateTime))
                {
                    e.Menu.Hide(ClauseType.Equals);
                    e.Menu.Remove(ClauseType.DoesNotEqual);
                    e.Menu.Hide(DevExpress.XtraEditors.Controls.StringId.FilterAdvancedDateTimeOperatorMenuCaption);
                    var menuItem = e.Menu.Find(ClauseType.Between);
                    menuItem.Caption = "Between A and B";
                    //menuItem.ImageOptions.SvgImage = MySvgImage1;
                }
            }
        }
        private void OnQueryCustomFunctions(object sender, DevExpress.XtraGrid.Views.Grid.CustomFunctionEventArgs e) {
            if(e.PropertyType == typeof(DateTime)) {
                e.Add(IsWeekendFunction.FunctionName);
                if(e.IsFilterEditor)
                    e.Add(IsDaysInterval.FunctionName);
            }
        }
        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gridView1.OptionsView.FilterCriteriaDisplayStyle = barCheckItem1.Checked ? 
                DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Text : DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Visual;
        }
    }
}


