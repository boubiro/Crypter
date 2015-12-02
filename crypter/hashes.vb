Public Class hashes
    Public hash As Object
    Public Sub New(ByVal hash As Object)
        Me.hash = hash
    End Sub
    Public Function getHash() As Object
        Return hash
    End Function
    Public Function setHash(ByVal hash As Object)
        Me.hash = hash
    End Function
End Class
