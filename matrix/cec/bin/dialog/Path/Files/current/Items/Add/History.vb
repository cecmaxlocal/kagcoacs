Public Class History
    Public Interface IItems
          Dim Add As PropertyAttributes
    End Interface
End Class

Public Class PropertyAttributes
    Public Sub New(feature As Object)
        Me.Feature = feature
    End Sub

    Public Property Feature as Object
End Class