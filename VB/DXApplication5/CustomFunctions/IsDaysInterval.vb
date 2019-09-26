Imports DevExpress.Data.Filtering

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
        Public ReadOnly Property Category As FunctionCategory Implements ICustomFunctionOperatorBrowsable.Category
            Get
                Return FunctionCategory.DateTime
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
            Return operandIndex = 0 AndAlso type Is GetType(Date) OrElse operandIndex = 1 AndAlso type Is GetType(Integer)
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
            Dim dt As Date = Convert.ToDateTime(operands(0))
            Dim days As Integer = Convert.ToInt32(operands(1))
            Dim start As Date = Date.Today.AddDays(-days)
            Dim [end] As Date = Date.Today.AddDays(days)
            Return dt >= start AndAlso dt <= [end]
        End Function
        Public ReadOnly Property Name As String Implements ICustomFunctionOperator.Name
            Get
                Return FunctionName
            End Get
        End Property
        Public ReadOnly Property DisplayName As String Implements ICustomFunctionDisplayAttributes.DisplayName
            Get
                Return "Is days interval"
            End Get
        End Property
        Public ReadOnly Property Image As Object Implements ICustomFunctionDisplayAttributes.Image
            Get
                Return "SwitchTimeScalesTo;Size16x16;Colored"
            End Get
        End Property

        Public Function ResultType(ParamArray operands() As Type) As Type Implements ICustomFunctionOperator.ResultType
            Return GetType(Boolean)
        End Function
    End Class
End Namespace
