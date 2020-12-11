Imports System.IO



Module Module1
    Dim sr As New StreamWriter("d://bmpres.txt")
    Sub Main()
        Dim fs As New FileStream("d://bmp.bmp", FileMode.OpenOrCreate)

        Do Until False
            Write("enter the path")



            If Read() = "read" Then

                Dim bfr(9999999) As Byte
                fs.Read(bfr, 0, bfr.Length)
                sr.Flush()
                Dim sw As New StreamWriter("d://res.txt")
                sw.Flush()
                For Each b As Byte In bfr


                    Write(b)
                    sw.Write(b.ToString() +
                      "   ")
                    sr.Write(b.ToString() + "   ")
                    sr.Flush()


                Next
                sr.Dispose()
            Else


                Read()
                Dim sw As New StreamReader("d:/bmpb.txt")
                Dim wbfr(100000) As Byte
                Dim i As Integer
                Do Until sw.EndOfStream
                    wbfr(i) = sw.Read()
                    i += 1
                Loop
            End If




        Loop
    End Sub
    Function Read()
        Return Console.ReadLine()
    End Function
    Sub Write(ByVal msg As Object)
        Console.Write(msg.ToString() + "    ")
    End Sub
End Module
