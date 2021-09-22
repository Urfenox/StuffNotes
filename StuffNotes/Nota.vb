Public Class Nota
    Dim stuffPath As String
    Dim filefolderName As String
    Dim noteFilePath As String

    Private Sub Nota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub CheckNote(ByVal ruta As String)
        stuffPath = ruta
        For Each item As String In CosasConNotas
            If item.StartsWith("#") = False Then
                Dim parte As String() = item.Split("|")
                If parte(0) = ruta Then
                    If My.Computer.FileSystem.FileExists(parte(1)) = False Then
                        AgregarNota(parte(0))
                        Exit Sub
                    Else
                        VerNota(parte(1))
                        Exit Sub
                    End If
                End If
            End If
        Next
        AgregarNota(ruta)
    End Sub

    Sub VerNota(ByVal rutaNota As String)
        filefolderName = stuffPath.Remove(0, stuffPath.LastIndexOf("\") + 1)
        noteFilePath = rutaNota
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(noteFilePath)
    End Sub
    Sub AgregarNota(ByVal ruta As String)
        filefolderName = stuffPath.Remove(0, stuffPath.LastIndexOf("\") + 1)
        noteFilePath = DIRNotas & "\" & CreateRandomString(5) & filefolderName
    End Sub

    Private Sub Nota_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub btnSaveNote_Click(sender As Object, e As EventArgs) Handles btnSaveNote.Click
        If My.Computer.FileSystem.FileExists(noteFilePath) = True Then
            My.Computer.FileSystem.DeleteFile(noteFilePath)
        End If
        My.Computer.FileSystem.WriteAllText(noteFilePath, RichTextBox1.Text, False)
        My.Computer.FileSystem.WriteAllText(FileWithNoteList, vbCrLf & stuffPath & "|" & noteFilePath, True)
    End Sub

    Function CreateRandomString(ByVal largo As SByte) As String
        Try
            Dim obj As New Random()
            Dim posibles As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
            Dim longitud As Integer = posibles.Length
            Dim letra As Char
            Dim longitudnuevacadena As Integer = largo
            Dim nuevacadena As String = Nothing
            For i As Integer = 0 To longitudnuevacadena - 1
                letra = posibles(obj.[Next](longitud))
                nuevacadena += letra.ToString()
            Next
            Return nuevacadena
        Catch
        End Try
        Return Nothing
    End Function
End Class