Imports System.Web.SessionState

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' 在應用程式啟動時引發

    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' 在工作階段啟動時引發
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' 在每個要求開頭引發
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' 在一開始嘗試驗證使用時引發
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' 在錯誤發生時引發
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' 在工作階段結束時引發
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' 在應用程式結束時引發
    End Sub

End Class