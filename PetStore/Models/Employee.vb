Public Class Employee
    Private _name As String
    Private _email As String
    Private _age As Integer
    Private _roles As List(Of String)

    Public Sub New(name As String, email As String, age As Integer, roles As List(Of String))
        Me._name = name
        Me._email = email
        Me._age = age
        Me._roles = roles
    End Sub

End Class
