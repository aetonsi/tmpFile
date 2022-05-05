Module mod_main

    Sub Main()
        Dim tmp As String = IO.Path.GetTempFileName()
        Dim args As String = ""
        Dim arg As String
        For i = 0 To My.Application.CommandLineArgs.Count - 1
            arg = My.Application.CommandLineArgs(i)
            args &= arg & If(Not i = My.Application.CommandLineArgs.Count - 1, vbCrLf, "")
        Next


        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(tmp, False, utf8WithoutBom)
        file.Write(args)
        file.Close()

        Console.Write(tmp)


    End Sub

End Module
