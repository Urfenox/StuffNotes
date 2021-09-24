Imports Microsoft.Win32
Module Complementos
    Public DIRCommons As String = "C:\Users\" & Environment.UserName & "\AppData\Local\CRZ_Labs\StuffNotes"
    Public FileWithNoteList As String = DIRCommons & "\StuffWithNotes.lst"
    Public DIRNotas As String = DIRCommons & "\Notas"
    Public StuffWithNotes As New ArrayList

    Sub CommonLoad()
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
            LoadFileWithNote()
        Catch ex As Exception
            AddToLog("CommonStart(0)", "Error: " & ex.Message, True)
        End Try
        Try
            Dim RutaMenu As String = "SOFTWARE\Classes\Directory\shell\StuffNotes"
            Dim RegeditWriter As RegistryKey
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            If RegeditWriter Is Nothing Then
                Main.btnEnableDisableStuffNotes.Text = "Habilitar StuffNotes"
            Else
                Main.btnEnableDisableStuffNotes.Text = "Deshabilitar StuffNotes"
            End If
        Catch ex As Exception
            AddToLog("CommonStart(1)", "Error: " & ex.Message, True)
        End Try
    End Sub

    Sub SaveFileWithNote()
        Try
            Dim lineas As String = "# Lista de ficheros/carpetas con notas asociadas"
            For Each item As String In StuffWithNotes
                lineas = lineas & vbCrLf & item
            Next
            If My.Computer.FileSystem.FileExists(FileWithNoteList) = True Then
                My.Computer.FileSystem.DeleteFile(FileWithNoteList)
            End If
            My.Computer.FileSystem.WriteAllText(FileWithNoteList, lineas, False)
        Catch ex As Exception
            AddToLog("SaveFileWithNote", "Error: " & ex.Message, True)
        End Try
    End Sub

    Sub LoadFileWithNote()
        Try
            StuffWithNotes.Clear()
            Main.ListBox1.Items.Clear()
            For Each linea As String In IO.File.ReadLines(FileWithNoteList)
                If linea <> Nothing And linea.StartsWith("#") = False Then
                    StuffWithNotes.Add(linea)
                    Dim getPath As String() = linea.Split("|")
                    Main.ListBox1.Items.Add(getPath(0).Remove(0, getPath(0).LastIndexOf("\") + 1))
                End If
            Next
        Catch ex As Exception
            AddToLog("LoadFileWithNote", "Error: " & ex.Message, True)
        End Try
    End Sub

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
            RegeditWriter.SetValue("", "Stuff Notes", RegistryValueKind.String)
            RegeditWriter.SetValue("Icon", Application.ExecutablePath, RegistryValueKind.String)

            'Creacion del comando
            RutaMenu &= "\command"
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu)
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            End If
            RegeditWriter.SetValue("", """" & Application.ExecutablePath & """" & "Note|%V", RegistryValueKind.String)
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
            RegeditWriter.SetValue("", "Stuff Notes", RegistryValueKind.String)
            RegeditWriter.SetValue("Icon", Application.ExecutablePath, RegistryValueKind.String)

            'Creacion del comando
            RutaMenu &= "\command"
            RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            If RegeditWriter Is Nothing Then
                Registry.CurrentUser.CreateSubKey(RutaMenu)
                RegeditWriter = Registry.CurrentUser.OpenSubKey(RutaMenu, True)
            End If
            RegeditWriter.SetValue("", """" & Application.ExecutablePath & """" & "Note|%V", RegistryValueKind.String)
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