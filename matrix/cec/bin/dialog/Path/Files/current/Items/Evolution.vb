Imports System.Net.Http.Headers

Public Interface IEvolution
      Public Class Evolution
            Sub New(changes As ProductHeaderValue)
                  Me.Changes = changes
            End Sub

            Public Property Changes as ProductHeaderValue
      End Class
      Public Class AddItems
            Sub New(items As SwitchAttribute)
                  Me.Items = items
            End Sub

            Public Property Items as SwitchAttribute
      End Class
      Public Class Swift
            Sub New(blockChain As SourceLevels)
                  Me.BlockChain = blockChain
            End Sub

            Public Property BlockChain as SourceLevels
      End Class
End Interface