Imports Microsoft.Win32
Module Complementos

    Public DIRCommons As String = "C:\Users\" & Environment.UserName & "\AppData\Local\CRZ_Labs\StuffNotes"
    Public FileWithNoteList As String = DIRCommons & "\StuffWithNotes.lst"
    Public DIRNotas As String = DIRCommons & "\Notas"
    Public CosasConNotas As New ArrayList

    Sub AddToLog(ByVal from As String, ByVal content As String, Optional ByVal flag As Boolean = False)
        Try
            Dim finalContent As String
            If flag = True Then
                finalContent = "[!!!]" & content
            Else
                finalContent = content
            End If
            Dim Message As String = DateTime.Now.ToString("hh:mm:ss tt dd/MM/yyyy ") & from & " " & finalContent
            Console.WriteLine(Message)
            Try
                    My.Computer.FileSystem.WriteAllText(DIRCommons & "\Activity.log", vbCrLf & Message, True)
                Catch
                End Try
        Catch ex As Exception
            Console.WriteLine("[AddToLog@Complementos]Error: " & ex.Message)
        End Try
    End Sub
End Module
Module RegistroDeWindows

    Sub CrearMenus()
        Try
            Dim RutaMenu As String = "SOFTWARE\Classes\Directory\shell\StuffNotes"
            Dim RegeditWriter As RegistryKey
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu)
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            End If
            RegeditWriter.SetValue("Icon", Application.ExecutablePath, RegistryValueKind.String)
            RegeditWriter.SetValue("MUIVerb", "Stuff Notes", RegistryValueKind.String)
            RegeditWriter.SetValue("subcommands", "", RegistryValueKind.String) 'Nothing creo genera errores, deberia ser "" en el caso.

            RutaMenu &= "\shell"
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu)
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            End If

            'Creacion de las opciones que seran visibles dentro de 'Stuff Notes'
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\AddNote", True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu & "\AddNote")
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\AddNote", True)
            End If
            RegeditWriter.SetValue("", "Agregar Nota", RegistryValueKind.String)
            RegeditWriter.SetValue("Icon", Application.ExecutablePath, RegistryValueKind.String)
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\SeeNote", True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu & "\SeeNote")
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\SeeNote", True)
            End If
            RegeditWriter.SetValue("", "Ver Nota", RegistryValueKind.String)
            RegeditWriter.SetValue("Icon", Application.ExecutablePath, RegistryValueKind.String)

            'Creacion de la subllave command y creacion de acciones
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\AddNote\command", True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu & "\AddNote\command")
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\AddNote\command", True)
            End If
            RegeditWriter.SetValue("", """" & Application.ExecutablePath & """" & "Create|%V", RegistryValueKind.String)

            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\SeeNote\command", True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu & "\SeeNote\command")
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\SeeNote\command", True)
            End If
            RegeditWriter.SetValue("", """" & Application.ExecutablePath & """" & "Open|%V", RegistryValueKind.String)

        Catch ex As Exception
            AddToLog("CrearMenus(Folder)", "Error: " & ex.Message, True)
        End Try
        Try
            Dim RutaMenu As String = "SOFTWARE\Classes\*\shell\StuffNotes"
            Dim RegeditWriter As RegistryKey
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu)
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            End If
            RegeditWriter.SetValue("Icon", Application.ExecutablePath, RegistryValueKind.String)
            RegeditWriter.SetValue("MUIVerb", "Stuff Notes", RegistryValueKind.String)
            RegeditWriter.SetValue("subcommands", "", RegistryValueKind.String) 'Nothing creo genera errores, deberia ser "" en el caso.

            RutaMenu &= "\shell"
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu)
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            End If

            'Creacion de las opciones que seran visibles dentro de 'Stuff Notes'
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\AddNote", True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu & "\AddNote")
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\AddNote", True)
            End If
            RegeditWriter.SetValue("", "Agregar Nota", RegistryValueKind.String)
            RegeditWriter.SetValue("Icon", Application.ExecutablePath, RegistryValueKind.String)
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\SeeNote", True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu & "\SeeNote")
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\SeeNote", True)
            End If
            RegeditWriter.SetValue("", "Ver Nota", RegistryValueKind.String)
            RegeditWriter.SetValue("Icon", Application.ExecutablePath, RegistryValueKind.String)

            'Creacion de la subllave command y creacion de acciones
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\AddNote\command", True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu & "\AddNote\command")
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\AddNote\command", True)
            End If
            RegeditWriter.SetValue("", """" & Application.ExecutablePath & """" & "Create|%V", RegistryValueKind.String)

            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\SeeNote\command", True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu & "\SeeNote\command")
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu & "\SeeNote\command", True)
            End If
            RegeditWriter.SetValue("", """" & Application.ExecutablePath & """" & "Open|%V", RegistryValueKind.String)

        Catch ex As Exception
            AddToLog("CrearMenus(File)", "Error: " & ex.Message, True)
        End Try
    End Sub
    Sub EliminarMenus()
        Try
            Dim RutaMenu As String = "SOFTWARE\Classes\Directory\shell"
            Dim RegeditRemover As RegistryKey
            RegeditRemover = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            If RegeditRemover Is Nothing Then
                Exit Sub
            End If
            RegeditRemover.DeleteSubKeyTree("StuffNotes")
        Catch ex As Exception
            AddToLog("EliminarMenus(Folder)", "Error: " & ex.Message, True)
        End Try
        Try
            Dim RutaMenu As String = "SOFTWARE\Classes\*\shell"
            Dim RegeditRemover As RegistryKey
            RegeditRemover = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            If RegeditRemover Is Nothing Then
                Exit Sub
            End If
            RegeditRemover.DeleteSubKeyTree("StuffNotes")
        Catch ex As Exception
            AddToLog("EliminarMenus(File)", "Error: " & ex.Message, True)
        End Try
    End Sub
End Module