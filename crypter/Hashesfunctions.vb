Imports System.Security.Cryptography
Imports System.Text

Public Class Hashesfunctions

    

    Public Function sha1(ByVal text As String) As String
        Dim sha1hash As New SHA1Cng
        Dim textByte As Byte() = Encoding.UTF8.GetBytes(text)
        ' Return Convert.ToDecimal(sha1hash.ComputeHash(textByte))
        Return Convert.ToInt64(sha1hash.ComputeHash(textByte)).ToString

    End Function
    Public Shared Function hash(ByVal str As String, ByVal hashtype As hashes) As String
        Dim provider As Object = hashtype.getHash
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strOutput As String = ""
        Dim i As Integer
        bytValue = System.Text.Encoding.UTF8.GetBytes(str)
        bytHash = provider.ComputeHash(bytValue)
        provider.Clear()
        For i = 0 To bytHash.Length - 1
            strOutput &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next
        Return strOutput
    End Function

End Class
