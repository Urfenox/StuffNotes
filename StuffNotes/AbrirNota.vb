Public Class AbrirNota
    Dim stuffPath As String
    Dim filefolderName As String
    Dim noteFilePath As String

    Private Sub AbrirNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub VerNota(ByVal ruta As String)
        stuffPath = ruta
        filefolderName = stuffPath.Remove(0, stuffPath.LastIndexOf("\") + 1)
        noteFilePath = DIRNotas & "\" & filefolderName
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(noteFilePath)
        MsgBox(ruta)
    End Sub

    Private Sub AbrirNota_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class