Public Interface ITextAreas
       Public Shared Function Areas() As String
       Public Shared Function Text() As StrCode
End Interface

Public Class StrCode
       Public Overrides Function ToString() As String
              Return MyBase.ToString()
       End Function
End Class