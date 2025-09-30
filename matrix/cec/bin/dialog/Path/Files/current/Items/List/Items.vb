Public Class Items
       Public Interface IAddList
              Public Class QListPopup
                               Public ReadOnly Property AddListProperty As Object
                               Sub New(addListProperty As Object)
                                   Me.AddListProperty = addListProperty
                               End Sub
              End Class
       End Interface
End Class