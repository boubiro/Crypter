Imports System.Security.Cryptography

Public Class Form1
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox2.Text = calculatehash(RichTextBox1.Text)
    End Sub
    Private Function calculatehash(ByVal text As String)
        Return Hashesfunctions.hash(text, New hashes(getselectedhash))
    End Function
    Private Function getselectedhash() As Object
        Dim index As Integer = ComboBox1.SelectedIndex
        Select Case index
            Case 0
                Return New MD5CryptoServiceProvider
            Case 1
                Return New SHA1CryptoServiceProvider
            Case 2
                Return New DESCryptoServiceProvider
            Case 3
                Return New RIPEMD160Managed
        End Select
    End Function


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.crypto
    End Sub

    Private Sub RichTextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox4.KeyUp
        RichTextBox3.Text = encrpytion.Encrypt(RichTextBox4.Text, TextBox1.Text)
    End Sub

    Private Sub RichTextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox3.KeyUp
        RichTextBox4.Text = encrpytion.Decrypt(RichTextBox3.Text, TextBox1.Text)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        RichTextBox1.Clear()
        RichTextBox3.Clear()
        RichTextBox2.Clear()
        RichTextBox4.Clear()

    End Sub
End Class
