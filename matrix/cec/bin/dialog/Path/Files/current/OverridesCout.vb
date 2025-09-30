

Public class OverridesLivesBase
      Public Property IdeaSmile as Dialog = New Dialog()
end class

Public Class Dialog
      Public Shared Property Debian As String
            Get
                  Throw GetPSmiles()
            End Get
            Set
                  Throw SetPSmiles()
            End Set
      End Property

      Public Shared Property SetPSmiles As SetCheck

      Public Class SetCheck
      End Class


      Public Shared Property GetPSmiles As GetCheck

      Public Class GetCheck
      End Class


      Protected Friend Shared Function GFilesPSmiles() As Path

            Dim path = ErrLivesMessages()
            Return path
      End Function


      Private Shared Function ErrLivesMessages() As Path
            Throw New path
      End Function

      Public Class Path
      End Class

      Protected Friend Shared Function SFilesPSmiles() As Path

            Return New Path()
      End Function

End Class

Public Class OverridesLives
      Inherits OverridesLivesBase
End Class