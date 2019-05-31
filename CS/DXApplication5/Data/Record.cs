using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.Utils.Filtering;
using System.Collections;
using System.Diagnostics;
using System.Collections.ObjectModel;
using DevExpress.Utils.Svg;
using DevExpress.Utils.Filtering.Internal;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using DXSample.CustomFunctions;

namespace DXSample {
    public class Record : INotifyPropertyChanged {//, IEditableObject {
        public Record() {
            Details = new BindingList<Detail>();
            Details.Add(new Detail());
        }
        int id;
        public int ID {
            get { return id; }
            set {
                if (id != value) {
                    id = value;
                    OnPropertyChanged();
                }
            }
        }
        int parentID;
        public int ParentID {
            get { return parentID; }
            set {
                if (parentID != value) {
                    parentID = value;
                    OnPropertyChanged();
                }
            }
        }
        string text;
        public string Text {
            get { return text; }
            set {
                if (text != value) {
                    text = value;
                    OnPropertyChanged();
                }
            }
        }
        string info;
        [CustomFunction(NotBeginsWithFunction.FunctionName/*, Image = <image>*/)]
        public string Info {
            get { return info; }
            set {
                if (info != value) {
                    info = value;
                    OnPropertyChanged();
                }
            }
        }
        decimal? val;
        public decimal? Value {
            get { return val; }
            set {
                if (val != value) {
                    val = value;
                    OnPropertyChanged();
                }
            }
        }
        DateTime date;
        public DateTime Date {
            get { return date; }
            set {
                if (date != value) {
                    date = value;
                    OnPropertyChanged();
                }
            }
        }
        bool state;
        [Display(Name = "Check State")]
        public bool State {
            get { return state; }
            set {
                if (state != value) {
                    state = value;
                    OnPropertyChanged();
                }
            }
        }
        Image image;
        public Image Image {
            get { return image; }
            set {
                if (image != value) {
                    image = value;
                    OnPropertyChanged();
                }
            }
        }
        BindingList<Detail> details;
        public BindingList<Detail> Details {
            get { return details; }
            set {
                if (details != value) {
                    details = value;
                    OnPropertyChanged();
                }
            }
        }
        public override string ToString() {
            return string.Format("ID = {0}", ID, Text);
        }
        Detail detail;
        public Detail Detail {
            get { return detail; }
            set {
                if (detail != value) {
                    detail = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void BeginEdit() {

        }

        public void CancelEdit() {
            Text = "Hello";
            ID = 123;
        }

        public void EndEdit() {

        }
        public Test Test { get; set; }
    }

    public enum Test {
        [Description("Test Low")]
        Low = 1,
        [Description("Test Middle")]
        Middle = 2,
        [Description("Test High")]
        High = 3
    }
    public class Detail : INotifyPropertyChanged {
        public Detail() {
        }
        int id;
        public int ID {
            get { return id; }
            set {
                if (id != value) {
                    id = value;
                    OnPropertyChanged();
                }
            }
        }
        string name;
        public string Name {
            get { return name; }
            set {
                if (name != value) {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        string info;
        public string Info {
            get { return info; }
            set {
                if (info != value) {
                    info = value;
                    OnPropertyChanged();
                }
            }
        }
        bool state;
        [Display(Name = "Check State")]
        public bool State {
            get { return state; }
            set {
                if (state != value) {
                    state = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    public class Any {
        public int Test { get; set; }
    }

    public class DataHelper {
        public static BindingList<Record> GetData(int count, int detailCount) {
            BindingList<Record> records = new BindingList<Record>();
            for (int i = 0; i < count; i++) {
                records.Add(new Record() {
                    ParentID = i < 5 ? 1 : 2,
                    ID = i,
                    Text = string.Format("Text {0}", i),
                    Info = string.Format("Info {0} Line 1\r\n Line 2\r\n Line 3\r\n Line 4\r\n Line 5\r\n", i),
                    Date = DateTime.Now.AddDays(i-10),
                    State = i % 2 == 0,
                    //Image = SystemIcons.Information.ToBitmap(),
                    Value = (i * 0.00001M),
                    Detail = new Detail() { ID = i, Name = string.Format("Text {0}", i), State = i % 2 == 0 }
                });
                BindingList<Detail> details = new BindingList<Detail>();
                for (int j = 0; j < detailCount; j++) {
                    details.Add(new Detail() {
                        ID = j,
                        Name = string.Format("Text {0}", j),
                        Info = string.Format("Info {0}", j)
                    });
                }
                records[i].Details = details;
            }

            return records;
        }
        public static BindingList<Record> GetData(int count, int detailCount, int subDetailCount) {
            BindingList<Record> records = new BindingList<Record>();
            for (int i = 0; i < count; i++) {
                records.Add(new Record() {
                    ParentID = i < 5 ? 1 : 2,
                    ID = i,
                    Text = string.Format("Text {0}", 1),
                    Info = string.Format("Info {0} Line 1\r\n Line 2\r\n Line 3\r\n Line 4\r\n Line 5\r\n", i),
                    Date = i % 2 == 0 ? DateTime.Now.AddDays(i) : DateTime.MinValue,
                    State = i % 2 == 0,
                    Image = SystemIcons.Information.ToBitmap(),
                    Value = (i * 0.00001M),
                    Detail = new Detail() { ID = i, Name = string.Format("Text {0}", i) }
                });
                BindingList<Detail> details = new BindingList<Detail>();
                for (int j = 0; j < detailCount; j++) {
                    Detail detail = new Detail() {
                        ID = j,
                        Name = string.Format("Text {0}", j),
                        Info = string.Format("Info {0}", j)
                    };
                    //detail.Details = new BindingList<Detail>();
                    //for (int k = 0; k < subDetailCount; k++) {
                    //    detail.Details.Add(new Detail() {
                    //        ID = k,
                    //        Name = string.Format("Text {0}", k),
                    //        Info = string.Format("Info {0}", k)
                    //    });
                    //}
                    details.Add(detail);
                }
                records[i].Details = details;
            }

            return records;
        }
        public static BindingList<Record> GetData(int count) {
            BindingList<Record> records = new BindingList<Record>();
            for (int i = 0; i < count; i++)
                records.Add(new Record() {
                    ID = i,
                    ParentID = i > 3 ? i % 2 : i % 3,
                    Text = string.Format("Text{0}", i),
                    Date = i % 10 == 0 ? DateTime.Today.AddDays(i) : DateTime.Today.AddDays(i).AddMonths(i).AddYears(i / 2).AddHours(i),
                    Value = i % 2 == 0 ? (i * 1.1222213M) : (i * 1.02312M),
                    State = false,//i % 2 == 0,
                    Image = SystemIcons.Information.ToBitmap(),
                    Detail = new Detail() {
                        ID = i,
                        Name = string.Format("Text {0}", i),
                        Info = string.Format("Info {0}", i)
                    },
                    Info = string.Format("Info{0}", i % 2 == 0 ? i : i + 2),//string.Format("Line{0}\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line\r\n Line {0}", i) 
                    Test = i % 2 == 0 ? Test.Middle : Test.High
                });
            return records;
        }
        public static BindingList<Record> GetTestData() {
            BindingList<Record> records = new BindingList<Record>();
            records.Add(new Record {
                ID = 1,
                ParentID = 2,
                Text = "<image=add_16x16.png> Text Book1",
                //Dt = DateTime.Today,
                Value = 1,
                State = true,
                Image = SystemIcons.Information.ToBitmap(),
            });
            records.Add(new Record {
                ID = 2,
                ParentID = 2,
                Text = "<image=addfile_16x16.png> Text Book2",
                //Dt = DateTime.Today,
                Value = 33,
                State = true,
                Image = SystemIcons.Information.ToBitmap(),
            });
            records.Add(new Record {
                ID = 3,
                ParentID = 2,
                Text = "AH1",
                //Dt = DateTime.Today,
                Value = 2,
                State = true,
                Image = SystemIcons.Information.ToBitmap(),
            });
            records.Add(new Record {
                ID = 4,
                ParentID = 2,
                Text = "<image=additem_16x16.png> Text Book3",
                //Dt = DateTime.Today,
                Value = 12,
                State = true,
                Image = SystemIcons.Information.ToBitmap(),
            });
            records.Add(new Record {
                ID = 5,
                ParentID = 2,
                Text = "<image=apply_16x16.png> Text Book4",
                //Dt = DateTime.Today,
                Value = 22,
                State = true,
                Image = SystemIcons.Information.ToBitmap(),
            });
            return records;
        }
        public static BindingList<Detail> GetDetailData(int count) {
            BindingList<Detail> records = new BindingList<Detail>();
            for (int i = 0; i < count; i++)
                records.Add(new Detail() {
                    ID = i,
                    Name = string.Format("Text{0}", i),
                    Info = string.Format("Detail Info {0}", i)
                });
            return records;
        }
    }
}
