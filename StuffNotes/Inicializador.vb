Public Class Inicializador
    Public parametros As String

    Private Sub Inicializador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        parametros = Command()
        CommonStart()
        LeerParametros()
    End Sub

    Sub LeerParametros()
        Try
            Dim argumento As String() = parametros.Split("|")
            If parametros = Nothing Then
                Main.Show()
                Main.Focus()
            ElseIf parametros.StartsWith("Open") Then
                Nota.CheckNote(argumento(1))
                Nota.Show()
                Nota.Focus()
            ElseIf parametros.StartsWith("Create") Then
                Nota.CheckNote(argumento(1))
                Nota.Show()
                Nota.Focus()
            End If
        Catch ex As Exception
            AddToLog("LeerParametros", "Error: " & ex.Message, True)
        End Try
    End Sub

    Sub CommonStart()
        Try
            If My.Computer.FileSystem.DirectoryExists(DIRCommons) = False Then
                My.Computer.FileSystem.CreateDirectory(DIRCommons)
            End If
            If My.Computer.FileSystem.DirectoryExists(DIRNotas) = False Then
                My.Computer.FileSystem.CreateDirectory(DIRNotas)
            End If
            If My.Computer.FileSystem.FileExists(FileWithNoteList) = False Then
                My.Computer.FileSystem.WriteAllText(FileWithNoteList, "# Lista de ficheros/carpetas con notas asociadas", False)
            End If
            Main.GetStuffWithNotes()
        Catch ex As Exception
            AddToLog("CommonStart", "Error: " & ex.Message, True)
        End Try
    End Sub

End Class