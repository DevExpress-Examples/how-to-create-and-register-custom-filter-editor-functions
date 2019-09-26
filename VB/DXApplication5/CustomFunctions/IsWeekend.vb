Imports DevExpress.Data.Filtering

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
        Public ReadOnly Property Category As FunctionCategory Implements ICustomFunctionOperatorBrowsable.Category
            Get
                Return FunctionCategory.DateTime
            End Get
        End Property
        Public ReadOnly Property Description As String Implements ICustomFunctionOperatorBrowsable.Description
            Get
                Return "TEST TEST>"
            End Get
        End Property

        Public Function IsValidOperandCount(count As Integer) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandCount
            Return count = 1
        End Function
        Public Function IsValidOperandType(operandIndex As Integer, operandCount As Integer, type As Type) As Boolean Implements ICustomFunctionOperatorBrowsable.IsValidOperandType
            Return type Is GetType(Date)
        End Function
        Public ReadOnly Property MaxOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MaxOperandCount
            Get
                Return 1
            End Get
        End Property
        Public ReadOnly Property MinOperandCount As Integer Implements ICustomFunctionOperatorBrowsable.MinOperandCount
            Get
                Return 1
            End Get
        End Property
        Public Function Evaluate(ParamArray operands() As Object) As Object Implements ICustomFunctionOperator.Evaluate
            Dim dt As Date = Convert.ToDateTime(operands(0))
            Return dt.DayOfWeek = DayOfWeek.Sunday OrElse dt.DayOfWeek = DayOfWeek.Saturday
        End Function
        Public ReadOnly Property Name As String Implements ICustomFunctionOperator.Name
            Get
                Return FunctionName
            End Get
        End Property
        Public ReadOnly Property DisplayName As String Implements ICustomFunctionDisplayAttributes.DisplayName
            Get
                Return "Is weekend"
            End Get
        End Property
        Public ReadOnly Property Image As Object Implements ICustomFunctionDisplayAttributes.Image
            Get
                Return "DayView;Office2013"
            End Get
        End Property
        Public Function ResultType(ParamArray operands() As Type) As Type Implements ICustomFunctionOperator.ResultType
            Return GetType(Boolean)
        End Function
    End Class
End Namespace
