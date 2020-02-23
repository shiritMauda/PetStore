Imports System.Web.Mvc

Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult
            If SessionManager.IsConnect Then
                Return RedirectToAction("Index", "Pet")
            End If

            Return View()
        End Function
    End Class
End Namespace