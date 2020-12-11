Public Class Form1

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WebBrowser1.Url.ToString <> "https://www.facebook.com/home.php" Then
            Try
                load()
                WebBrowser1.Document.GetElementById("email").SetAttribute("value", "lawrence910426@yahoo.com.tw")

                load()
                WebBrowser1.Document.GetElementById("pass").SetAttribute("value", "Lawrence Sean4011")

                load()
                WebBrowser1.Document.GetElementById("loginbutton").InvokeMember("submit")

                '寫此程式之人必會些許html
            Catch
            End Try
        Else


            MsgBox("welcome to fb")
        End If

        load()




    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Refresh()

        WebBrowser1.Navigate("https://www.facebook.com/home.php")
        load()


    End Sub
    Sub load()
        Do Until Not WebBrowser1.IsBusy
        Loop
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

        Catch
            WebBrowser1.Navigate(TextBox1.Text)
        End Try

    End Sub



End Class




