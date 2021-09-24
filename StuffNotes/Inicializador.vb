Public Class Inicializador
    Public parametros As String

    Private Sub Inicializador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        parametros = Command()
        CommonLoad()
        LeerParametros()
    End Sub

    Sub LeerParametros()
        Try
            Dim argumento As String() = parametros.Split("|")
            If parametros = Nothing Then
                Main.Show()
                Main.Focus()
            ElseIf parametros.StartsWith("Note") Then
                Nota.CheckNote(argumento(1))
                Nota.Show()
                Nota.Focus()
            End If
        Catch ex As Exception
            AddToLog("LeerParametros", "Error: " & ex.Message, True)
        End Try
    End Sub
End Class