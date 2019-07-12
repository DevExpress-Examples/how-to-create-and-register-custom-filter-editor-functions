Imports DevExpress.Data.Filtering
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DXSample.CustomFunctions
	Public Class NotBeginsWithFunction
		Implements ICustomFunctionDisplayAttributes

		Public Const FunctionName As String = "NotBeginsWith"
		Private Shared ReadOnly instance As New NotBeginsWithFunction()
		Public Shared Sub Register()
			CriteriaOperator.RegisterCustomFunction(instance)
		End Sub
		Public Shared Function Unregister() As Boolean
			Return CriteriaOperator.UnregisterCustomFunction(instance)
		End Function
		Public ReadOnly Property Category() As FunctionCategory
			Get
				Return FunctionCategory.Text
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
			Return type Is GetType(String)
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
			If operands(0) IsNot Nothing AndAlso operands(1) IsNot Nothing Then
				Dim str1 As String = operands(0).ToString()
				Dim str2 As String = operands(1).ToString()
				Return Not str1.StartsWith(str2, StringComparison.InvariantCultureIgnoreCase)
			End If
			Return False
		End Function
		Public ReadOnly Property Name() As String
			Get
				Return FunctionName
			End Get
		End Property
		Public ReadOnly Property DisplayName() As String
			Get
				Return "Not begins with"
			End Get
		End Property
		Public ReadOnly Property Image() As Object
			Get
				Return "FontSizeDecrease;Office2013"
			End Get
		End Property
		Public Function ResultType(ParamArray ByVal operands() As Type) As Type
			Return GetType(Boolean)
		End Function
	End Class
End Namespace
