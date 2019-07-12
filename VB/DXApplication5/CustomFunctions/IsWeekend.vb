Imports DevExpress.Data.Filtering
Imports DevExpress.Utils.Svg
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DXSample
	Public Class IsWeekendFunction
		Implements ICustomFunctionDisplayAttributes

		Public Const FunctionName As String = "IsWeekend"
		Private Shared ReadOnly instance As New IsWeekendFunction()

		Public Shared Sub Register()
			CriteriaOperator.RegisterCustomFunction(instance)
		End Sub
		Public Shared Function Unregister() As Boolean
			Return CriteriaOperator.UnregisterCustomFunction(instance)
		End Function
		Public ReadOnly Property Category() As FunctionCategory
			Get
				Return FunctionCategory.DateTime
			End Get
		End Property
		Public ReadOnly Property Description() As String
			Get
				Return "TEST TEST>"
			End Get
		End Property

		Public Function IsValidOperandCount(ByVal count As Integer) As Boolean
			Return count = 1
		End Function
		Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean
			Return type Is GetType(Date)
		End Function
		Public ReadOnly Property MaxOperandCount() As Integer
			Get
				Return 1
			End Get
		End Property
		Public ReadOnly Property MinOperandCount() As Integer
			Get
				Return 1
			End Get
		End Property
		Public Function Evaluate(ParamArray ByVal operands() As Object) As Object
			Dim dt As Date = Convert.ToDateTime(operands(0))
			Return dt.DayOfWeek = DayOfWeek.Sunday OrElse dt.DayOfWeek = DayOfWeek.Saturday
		End Function
		Public ReadOnly Property Name() As String
			Get
				Return FunctionName
			End Get
		End Property
		Public ReadOnly Property DisplayName() As String
			Get
				Return "Is weekend"
			End Get
		End Property
		Public ReadOnly Property Image() As Object
			Get
				Return "DayView;Office2013"
			End Get
		End Property
		Public Function ResultType(ParamArray ByVal operands() As Type) As Type
			Return GetType(Boolean)
		End Function
	End Class
End Namespace
