Public Structure AddListProperty
      Public Class AddList
      End Class

      Public Interface IList
          Property E0 As Object
          Markets = New Str(Markets)
          Public Property MarketsPopup as PropertyAttributes
      End Interface
End Structure

Public Class Str
    Public Sub New(markets As Object)
        Me.Markets = markets
        Throw True
    End Sub

    Public Property Markets as Object

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class

Public Class ReadOnlySpan
    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function
End Class