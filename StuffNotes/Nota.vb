Public Class Nota
    Dim stuffPath As String
    Dim filefolderName As String
    Dim noteFilePath As String
    Dim indice As Integer = 0
    Public UserClose As Boolean = False

    Private Sub Nota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub CheckNote(ByVal ruta As String)
        stuffPath = ruta
        For Each item As String In StuffWithNotes
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
            indice += 1
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
    Sub GuardarNota()
        If My.Computer.FileSystem.FileExists(noteFilePath) = True Then
            My.Computer.FileSystem.DeleteFile(noteFilePath)
        Else
            My.Computer.FileSystem.WriteAllText(FileWithNoteList, vbCrLf & stuffPath & "|" & noteFilePath, True)
        End If
        My.Computer.FileSystem.WriteAllText(noteFilePath, RichTextBox1.Text, False)
        MsgBox("Nota guardada", MsgBoxStyle.Information, "Nota")
    End Sub

    Private Sub Nota_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If UserClose = False Then
            End
        End If
    End Sub

    Private Sub btnSaveNote_Click(sender As Object, e As EventArgs) Handles btnSaveNote.Click
        GuardarNota()
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

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        GuardarNota()
    End Sub

    Private Sub GuardarcomoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarcomoToolStripMenuItem.Click
        Dim SaveFile As New SaveFileDialog
        SaveFile.Filter = "Archivo Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        SaveFile.Title = "Guardar como..."
        If SaveFile.ShowDialog() = DialogResult.OK Then
            If My.Computer.FileSystem.FileExists(SaveFile.FileName) = True Then
                My.Computer.FileSystem.DeleteFile(SaveFile.FileName)
            End If
            My.Computer.FileSystem.WriteAllText(SaveFile.FileName, RichTextBox1.Text, False)
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub PersonalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalizarToolStripMenuItem.Click
        Dim Font As New FontDialog
        If Font.ShowDialog() = DialogResult.OK Then
            RichTextBox1.Font = Font.Font
        End If
    End Sub

    Private Sub NoHelpLmaoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoHelpLmaoToolStripMenuItem.Click
        Process.Start("https://github.com/Urfenox/StuffNotes")
    End Sub

    Private Sub HoraYFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoraYFechaToolStripMenuItem.Click
        RichTextBox1.AppendText(Now.ToShortTimeString & " " & Now.ToShortDateString)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            If MessageBox.Show("¿Seguro desea eliminar la nota?", "Eliminar Nota", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                StuffWithNotes.RemoveAt(indice)
                If My.Computer.FileSystem.FileExists(noteFilePath) = True Then
                    My.Computer.FileSystem.DeleteFile(noteFilePath)
                End If
            End If
            SaveFileWithNote()
            End
        Catch ex As Exception
            AddToLog("EliminarToolStripMenuItem_Click", "Error: " & ex.Message, True)
        End Try
    End Sub

    'Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
    '    RichTextBox1.Undo()
    'End Sub

    'Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
    '    RichTextBox1.Redo()
    'End Sub

    'Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
    '    My.Computer.Clipboard.SetText(RichTextBox1.SelectedText)
    '    RichTextBox1.SelectedText = Nothing
    'End Sub

    'Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
    '    My.Computer.Clipboard.SetText(RichTextBox1.SelectedText)
    'End Sub

    'Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
    '    RichTextBox1.AppendText(My.Computer.Clipboard.GetText)
    'End Sub

    'Private Sub SeleccionartodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionartodoToolStripMenuItem.Click
    '    RichTextBox1.SelectAll()
    'End Sub
End Class