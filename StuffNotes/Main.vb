Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetStuffWithNotes()
    End Sub

    Sub GetStuffWithNotes()
        Try
            CosasConNotas.Clear()
            ListBox1.Items.Clear()
            For Each linea As String In IO.File.ReadLines(FileWithNoteList)
                If linea <> Nothing Then
                    CosasConNotas.Add(linea)
                    Dim getPath As String() = linea.Split("|")
                    ListBox1.Items.Add(getPath(0).Remove(0, getPath(0).LastIndexOf("\") + 1))
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEnableDisableStuffNotes_Click(sender As Object, e As EventArgs) Handles btnEnableDisableStuffNotes.Click
        If btnEnableDisableStuffNotes.Text = "Habilitar StuffNotes" Then
            CrearMenus()
            btnEnableDisableStuffNotes.Text = "Deshabilitar StuffNotes"
        Else
            EliminarMenus()
            btnEnableDisableStuffNotes.Text = "Habilitar StuffNotes"
        End If
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class