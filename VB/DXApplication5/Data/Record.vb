Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.Utils.Filtering
Imports System.Collections
Imports System.Diagnostics
Imports System.Collections.ObjectModel
Imports DevExpress.Utils.Svg
Imports DevExpress.Utils.Filtering.Internal
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors
Imports DXSample.CustomFunctions

Namespace DXSample
	Public Class Record
		Implements INotifyPropertyChanged
 ', IEditableObject {
		Public Sub New()
			Details = New BindingList(Of Detail)()
			Details.Add(New Detail())
		End Sub
'INSTANT VB NOTE: The field id was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private id_Renamed As Integer
		Public Property ID() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				If id_Renamed <> value Then
					id_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field parentID was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private parentID_Renamed As Integer
		Public Property ParentID() As Integer
			Get
				Return parentID_Renamed
			End Get
			Set(ByVal value As Integer)
				If parentID_Renamed <> value Then
					parentID_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field text was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private text_Renamed As String
		Public Property Text() As String
			Get
				Return text_Renamed
			End Get
			Set(ByVal value As String)
				If text_Renamed <> value Then
					text_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field info was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private info_Renamed As String
		<CustomFunction(NotBeginsWithFunction.FunctionName)>
		Public Property Info() As String
			Get
				Return info_Renamed
			End Get
			Set(ByVal value As String)
				If info_Renamed <> value Then
					info_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property
		Private val? As Decimal
		Public Property Value() As Decimal?
			Get
				Return val
			End Get
			Set(ByVal value? As Decimal)
				If Not val.Equals(value) Then
					val = value
					OnPropertyChanged()
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field date was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private date_Renamed As Date
		Public Property [Date]() As Date
			Get
				Return date_Renamed
			End Get
			Set(ByVal value As Date)
				If date_Renamed <> value Then
					date_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field state was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private state_Renamed As Boolean
		<Display(Name := "Check State")>
		Public Property State() As Boolean
			Get
				Return state_Renamed
			End Get
			Set(ByVal value As Boolean)
				If state_Renamed <> value Then
					state_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field image was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private image_Renamed As Image
		Public Property Image() As Image
			Get
				Return image_Renamed
			End Get
			Set(ByVal value As Image)
				If image_Renamed IsNot value Then
					image_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field details was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private details_Renamed As BindingList(Of Detail)
		Public Property Details() As BindingList(Of Detail)
			Get
				Return details_Renamed
			End Get
			Set(ByVal value As BindingList(Of Detail))
				If details_Renamed IsNot value Then
					details_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property
		Public Overrides Function ToString() As String
			Return String.Format("ID = {0}", ID, Text)
		End Function
'INSTANT VB NOTE: The field detail was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private detail_Renamed As Detail
		Public Property Detail() As Detail
			Get
				Return detail_Renamed
			End Get
			Set(ByVal value As Detail)
				If detail_Renamed IsNot value Then
					detail_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Protected Sub OnPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = "")
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

		Public Sub BeginEdit()

		End Sub

		Public Sub CancelEdit()
			Text = "Hello"
			ID = 123
		End Sub

		Public Sub EndEdit()

		End Sub
		Public Property Test() As Test
	End Class

	Public Enum Test
		<Description("Test Low")>
		Low = 1
		<Description("Test Middle")>
		Middle = 2
		<Description("Test High")>
		High = 3
	End Enum
	Public Class Detail
		Implements INotifyPropertyChanged

		Public Sub New()
		End Sub
'INSTANT VB NOTE: The field id was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private id_Renamed As Integer
		Public Property ID() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				If id_Renamed <> value Then
					id_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field name was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private name_Renamed As String
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				If name_Renamed <> value Then
					name_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field info was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private info_Renamed As String
		Public Property Info() As String
			Get
				Return info_Renamed
			End Get
			Set(ByVal value As String)
				If info_Renamed <> value Then
					info_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property
'INSTANT VB NOTE: The field state was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private state_Renamed As Boolean
		<Display(Name := "Check State")>
		Public Property State() As Boolean
			Get
				Return state_Renamed
			End Get
			Set(ByVal value As Boolean)
				If state_Renamed <> value Then
					state_Renamed = value
					OnPropertyChanged()
				End If
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Protected Sub OnPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = "")
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

	End Class
	Public Class Any
		Public Property Test() As Integer
	End Class

	Public Class DataHelper
		Public Shared Function GetData(ByVal count As Integer, ByVal detailCount As Integer) As BindingList(Of Record)
			Dim records As New BindingList(Of Record)()
			For i As Integer = 0 To count - 1
				records.Add(New Record() With {
					.ParentID = If(i < 5, 1, 2),
					.ID = i,
					.Text = String.Format("Text {0}", i),
					.Info = String.Format("Info {0} Line 1" & vbCrLf & " Line 2" & vbCrLf & " Line 3" & vbCrLf & " Line 4" & vbCrLf & " Line 5" & vbCrLf, i),
					.Date = Date.Now.AddDays(i-10),
					.State = i Mod 2 = 0,
					.Value = (i * 0.00001D),
					.Detail = New Detail() With {
						.ID = i,
						.Name = String.Format("Text {0}", i),
						.State = i Mod 2 = 0
					}
				})
				Dim details As New BindingList(Of Detail)()
				For j As Integer = 0 To detailCount - 1
					details.Add(New Detail() With {
						.ID = j,
						.Name = String.Format("Text {0}", j),
						.Info = String.Format("Info {0}", j)
					})
				Next j
				records(i).Details = details
			Next i

			Return records
		End Function
		Public Shared Function GetData(ByVal count As Integer, ByVal detailCount As Integer, ByVal subDetailCount As Integer) As BindingList(Of Record)
			Dim records As New BindingList(Of Record)()
			For i As Integer = 0 To count - 1
				records.Add(New Record() With {
					.ParentID = If(i < 5, 1, 2),
					.ID = i,
					.Text = String.Format("Text {0}", 1),
					.Info = String.Format("Info {0} Line 1" & vbCrLf & " Line 2" & vbCrLf & " Line 3" & vbCrLf & " Line 4" & vbCrLf & " Line 5" & vbCrLf, i),
					.Date = If(i Mod 2 = 0, Date.Now.AddDays(i), Date.MinValue),
					.State = i Mod 2 = 0,
					.Image = SystemIcons.Information.ToBitmap(),
					.Value = (i * 0.00001D),
					.Detail = New Detail() With {
						.ID = i,
						.Name = String.Format("Text {0}", i)
					}
				})
				Dim details As New BindingList(Of Detail)()
				For j As Integer = 0 To detailCount - 1
					Dim detail As New Detail() With {
						.ID = j,
						.Name = String.Format("Text {0}", j),
						.Info = String.Format("Info {0}", j)
					}
					'detail.Details = new BindingList<Detail>();
					'for (int k = 0; k < subDetailCount; k++) {
					'    detail.Details.Add(new Detail() {
					'        ID = k,
					'        Name = string.Format("Text {0}", k),
					'        Info = string.Format("Info {0}", k)
					'    });
					'}
					details.Add(detail)
				Next j
				records(i).Details = details
			Next i

			Return records
		End Function
		Public Shared Function GetData(ByVal count As Integer) As BindingList(Of Record)
			Dim records As New BindingList(Of Record)()
			For i As Integer = 0 To count - 1
				records.Add(New Record() With {
					.ID = i,
					.ParentID = If(i > 3, i Mod 2, i Mod 3),
					.Text = String.Format("Text{0}", i),
					.Date = If(i Mod 10 = 0, Date.Today.AddDays(i), Date.Today.AddDays(i).AddMonths(i).AddYears(i \ 2).AddHours(i)),
					.Value = If(i Mod 2 = 0, (i * 1.1222213D), (i * 1.02312D)),
					.State = False,
					.Image = SystemIcons.Information.ToBitmap(),
					.Detail = New Detail() With {
						.ID = i,
						.Name = String.Format("Text {0}", i),
						.Info = String.Format("Info {0}", i)
					},
					.Info = String.Format("Info{0}",If(i Mod 2 = 0, i, i + 2)),
					.Test = If(i Mod 2 = 0, Test.Middle, Test.High)
				})
			Next i
			Return records
		End Function
		Public Shared Function GetTestData() As BindingList(Of Record)
			Dim records As New BindingList(Of Record)()
			records.Add(New Record With {
				.ID = 1,
				.ParentID = 2,
				.Text = "<image=add_16x16.png> Text Book1",
				.Value = 1,
				.State = True,
				.Image = SystemIcons.Information.ToBitmap()
			})
			records.Add(New Record With {
				.ID = 2,
				.ParentID = 2,
				.Text = "<image=addfile_16x16.png> Text Book2",
				.Value = 33,
				.State = True,
				.Image = SystemIcons.Information.ToBitmap()
			})
			records.Add(New Record With {
				.ID = 3,
				.ParentID = 2,
				.Text = "AH1",
				.Value = 2,
				.State = True,
				.Image = SystemIcons.Information.ToBitmap()
			})
			records.Add(New Record With {
				.ID = 4,
				.ParentID = 2,
				.Text = "<image=additem_16x16.png> Text Book3",
				.Value = 12,
				.State = True,
				.Image = SystemIcons.Information.ToBitmap()
			})
			records.Add(New Record With {
				.ID = 5,
				.ParentID = 2,
				.Text = "<image=apply_16x16.png> Text Book4",
				.Value = 22,
				.State = True,
				.Image = SystemIcons.Information.ToBitmap()
			})
			Return records
		End Function
		Public Shared Function GetDetailData(ByVal count As Integer) As BindingList(Of Detail)
			Dim records As New BindingList(Of Detail)()
			For i As Integer = 0 To count - 1
				records.Add(New Detail() With {
					.ID = i,
					.Name = String.Format("Text{0}", i),
					.Info = String.Format("Detail Info {0}", i)
				})
			Next i
			Return records
		End Function
	End Class
End Namespace
