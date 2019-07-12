Imports DevExpress.Data.Filtering
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DXSample
	Friend Class IsDaysInterval
		Implements ICustomFunctionDisplayAttributes

		Public Const FunctionName As String = "IsDaysInterval"
		Private Shared ReadOnly instance As New IsDaysInterval()

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
				Return "<description>"
			End Get
		End Property
		Public Function IsValidOperandCount(ByVal count As Integer) As Boolean
			Return count = 2
		End Function
		Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean
			Return operandIndex = 0 AndAlso type Is GetType(Date) OrElse operandIndex = 1 AndAlso type Is GetType(Integer)
		End Function
		Public ReadOnly Property MaxOperandCount() As Integer
			Get
				Return 2
			End Get
		End Property
		Public ReadOnly Property MinOperandCount() As Integer
			Get
				Return 2
			End Get
		End Property
		Public Function Evaluate(ParamArray ByVal operands() As Object) As Object
			Dim dt As Date = Convert.ToDateTime(operands(0))
			Dim days As Integer = Convert.ToInt32(operands(1))
			Dim start As Date = Date.Today.AddDays(-days)
			Dim [end] As Date = Date.Today.AddDays(days)
			Return dt >= start AndAlso dt <= [end]
		End Function
		Public ReadOnly Property Name() As String
			Get
				Return FunctionName
			End Get
		End Property
		Public ReadOnly Property DisplayName() As String
			Get
				Return "Is days interval"
			End Get
		End Property
		Public ReadOnly Property Image() As Object
			Get
				Return "SwitchTimeScalesTo;Size16x16;Colored"
			End Get
		End Property

		Public Function ResultType(ParamArray ByVal operands() As Type) As Type
			Return GetType(Boolean)
		End Function
	End Class
End Namespace
