
Imports System.IO










Module Module1

    Sub Main()
        Dim fs As New FileStream("d://output/res.bmp", FileMode.OpenOrCreate)
        Dim sr As New StreamReader("d://bmp.txt")
        Do Until False
            Dim s As String = sr.ReadToEnd()
            Dim splts() = s.Split("   ")
            For Each i As String In splts
                fs.WriteByte(Val(i))
            Next
            fs.Flush()
        Loop
    End Sub

End Module
