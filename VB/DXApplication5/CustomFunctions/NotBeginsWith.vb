Imports DevExpress.Data.Filtering

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
        Public ReadOnly Property Category As FunctionCategory Implements ICustomFunctionOperatorBrowsable.Category
            Get
                Return FunctionCategory.Text
            End Get
        End Property
        Public ReadOnly Property Description As String Implements ICustomFunctionOperatorBrowsable.Description
            Get
                Return "<description>"
            End Get
        End Property
        Public Function IsValidOperandCount(count As Integer) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandCount
            Return count = 2
        End Function
        Public Function IsValidOperandType(operandIndex As Integer, operandCount As Integer, type As Type) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandType
            Return type Is GetType(String)
        End Function
        Public ReadOnly Property MaxOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MaxOperandCount
            Get
                Return 2
            End Get
        End Property
        Public ReadOnly Property MinOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MinOperandCount
            Get
                Return 2
            End Get
        End Property
        Public Function Evaluate(ParamArray operands() As Object) As Object Implements ICustomFunctionOperator.Evaluate
            If operands(0) IsNot Nothing AndAlso operands(1) IsNot Nothing Then
                Dim str1 As String = operands(0).ToString()
                Dim str2 As String = operands(1).ToString()
                Return Not str1.StartsWith(str2, StringComparison.InvariantCultureIgnoreCase)
            End If
            Return False
        End Function
        Public ReadOnly Property Name As String Implements ICustomFunctionOperator.Name
            Get
                Return FunctionName
            End Get
        End Property
        Public ReadOnly Property DisplayName As String Implements ICustomFunctionDisplayAttributes.DisplayName
            Get
                Return "Not begins with"
            End Get
        End Property
        Public ReadOnly Property Image As Object Implements ICustomFunctionDisplayAttributes.Image
            Get
                Return "FontSizeDecrease;Office2013"
            End Get
        End Property
        Public Function ResultType(ParamArray operands() As Type) As Type Implements ICustomFunctionOperator.ResultType
            Return GetType(Boolean)
        End Function
    End Class
End Namespace
