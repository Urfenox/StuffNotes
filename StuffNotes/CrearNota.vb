Public Class CrearNota
    Dim stuffPath As String
    Dim filefolderName As String
    Dim noteFilePath As String

    Private Sub CrearNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub AgregarNota(ByVal ruta As String)
        stuffPath = ruta
        filefolderName = stuffPath.Remove(0, stuffPath.LastIndexOf("\") + 1)
        noteFilePath = DIRNotas & "\" & filefolderName
        'quedaria raro ej: "hola.txt.txt" en el caso de archivo. y "hola.txt" en el caso de carpeta
        '   xd, mejor no pongo la extencion, se ve mas bonito.
        MsgBox(ruta)
    End Sub

    Private Sub CrearNota_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub btnSaveNote_Click(sender As Object, e As EventArgs) Handles btnSaveNote.Click

        'guardar nota en archivo
        If My.Computer.FileSystem.FileExists(noteFilePath) = True Then
            My.Computer.FileSystem.DeleteFile(noteFilePath)
        End If
        My.Computer.FileSystem.WriteAllText(noteFilePath, RichTextBox1.Text, False)

        'tomar la ruta de la cosa seleccionada y juntarla con la ruta de la nota
        My.Computer.FileSystem.WriteAllText(FileWithNoteList, vbCrLf & stuffPath & "|" & noteFilePath, True)

        '(?)PROBLEMA: puede ser que se dupliquen ciertos items en el archivo lista.
        '   realmente no, esto no pasara si se comprueba la existencia de una nota.
    End Sub
End Class
'seria genial poder discriminar si es archivo o carpeta.