Public Class Inicializador
    Public parametros As String

    Private Sub Inicializador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        parametros = Command()
        'leemos parametros
        LeerParametros()
    End Sub

    Sub LeerParametros()
        'procesamos el parametro
        'OJO: solo existe un parametro de inicio
        '   el que indica la ruta y tipo de inicio
        '   ruta: C:\...\...
        '   tipo de inicio: si es Ver o Agregar nota
        '   un string bonito seria:
        '       FORMATO: <TIPO DE INICIO>|<RUTA>
        '       entendiendo que en el regedit "%L o %V" se reemplaza por la cosa que esta iniciando

        'basicamente, necesitamos algo elegante y bonito
        '   creo que leer esto es mas simple
        '   estoy volao.
        Try
            'argumento()
            '       0           1
            '<TIPO DE INICIO>|<RUTA>
            Dim argumento As String() = parametros.Split("|")
            If parametros = Nothing Then
                CommonStart()
                Main.Show()
                Main.Focus()
            ElseIf parametros.StartsWith("Open") Then
                AbrirNota.VerNota(argumento(1))
                AbrirNota.Show()
                AbrirNota.Focus()
            ElseIf parametros.StartsWith("Create") Then
                CrearNota.AgregarNota(argumento(1))
                CrearNota.Show()
                CrearNota.Focus()
            End If

            'AVISO: Esto es por ahora, esto en el futuro deberia llamar a una unificacion para ver si existe o no una nota asociada.

        Catch ex As Exception
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
                My.Computer.FileSystem.WriteAllText(FileWithNoteList, Nothing, False)
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class