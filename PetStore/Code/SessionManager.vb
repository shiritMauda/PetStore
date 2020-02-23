Public Class SessionManager
    Const _EMP As String = "Employee"
    Private Shared _session As SessionState.HttpSessionState
    Private Shared ReadOnly Property Session() As SessionState.HttpSessionState
        Get
            If _session Is Nothing Then
                _session = HttpContext.Current.Session
            End If
            Return _session
        End Get
    End Property


    Public Shared Property Employee() As Employee
        Get
            Return Session(_EMP)
        End Get
        Set(ByVal e As Employee)
            Session(_EMP) = e
        End Set
    End Property


    Public Shared ReadOnly Property IsConnect() As Boolean
        Get
            Return Employee IsNot Nothing
        End Get

    End Property
End Class
