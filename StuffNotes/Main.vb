Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        SaveFileWithNote()
        End
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        Try
            If ListBox1.SelectedItem <> Nothing Then
                Nota.Show()
                Nota.Focus()
                Dim rutaNota As String() = StuffWithNotes(ListBox1.SelectedIndex).ToString.Split("|")
                Nota.CheckNote(rutaNota(0))
                Nota.UserClose = True
            End If
        Catch
        End Try
    End Sub

    Private Sub Main_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Text = "StuffNotes creado por Urfenox"
        CommonLoad()
        Me.Refresh()
        Me.CenterToScreen()
        If MessageBox.Show("¿Quiere ir al sitio web del software?", "Ayuda", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Process.Start("https://github.com/Urfenox/StuffNotes")
        End If
        Text = "Stuff Notes"
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim archivoRuta As String() = StuffWithNotes(ListBox1.SelectedIndex).ToString.Split("|")
        Label1.Text = "Ref: " & archivoRuta(0)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim archivoRuta As String() = StuffWithNotes(ListBox1.SelectedIndex).ToString.Split("|")
        Process.Start(archivoRuta(0))
    End Sub
End Class