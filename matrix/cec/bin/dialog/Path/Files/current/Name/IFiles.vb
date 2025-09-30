Public Interface IFiles
     Public Overrides Property BufferFiles()
End Interface

Public Class BufferList
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Sub New(bufferFiles As Object)
        Files = bufferFiles
    End Sub

    Public Property Files as Object = New Dialog.Path() <> E0()

    Public Property E0 As Object

End Class