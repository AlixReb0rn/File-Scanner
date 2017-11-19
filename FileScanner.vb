Module Module1

    Sub Main()
        Try
            Do
                'This Scanner Created By Alix Reb0rn Please Subscribe.
                Console.Clear()

                Console.WriteLine("Drop A File to Start Scanning it : Remove """"")

                Dim FileName As String

                FileName = Console.ReadLine()
                Dim ExeInfo As System.IO.FileInfo
                ExeInfo = My.Computer.FileSystem.GetFileInfo(FileName)


                If My.Computer.FileSystem.OpenTextFileReader(FileName).ReadToEnd.Contains("cheatengine") Then


                    Console.WriteLine("File Name : " & FileName)
                    Console.WriteLine("File Size : " & ExeInfo.Length & " Bytes")
                    Console.WriteLine("File Extension : " & ExeInfo.Extension)
                    Console.WriteLine("Scan Result : " & "CheatTool:CheatEngine Trainer")
                    Console.Read()



                End If


            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Module
