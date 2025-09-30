Public Class Govern
      Public Structure AddList
            Public Overrides Function ToString() As String
                  Return MyBase.ToString()
            End Function
      End Structure
      Public Class GetList
            Property List() As String
            Shared Property Add() As String
            Public Shared Property Create as String
      End Class
      Public Class SettList
            Property List() As String
            Shared Property Add() As String
            Public Shared Property Create as String
      End Class

End Class