Public Interface ICode
    Public Shared Function Command() As Code.Vb
End Interface

Public Class Code
    Public Class Vb
        Public Overrides Function ToString() As String
            Return MyBase.ToString()
        End Function
    End Class
End Class