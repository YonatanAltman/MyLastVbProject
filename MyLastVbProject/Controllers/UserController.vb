Imports System.Web.Mvc

Namespace Controllers
    Public Class UserController
        Inherits Controller

        ' GET: User
        Function Index() As ActionResult
            ' go to DB and select all users
            Dim users As New List(Of UserModel) From {
                New UserModel(111, "Yonatan", "Altman", New DateTime(2019, 1, 2)),
                New UserModel(111, "Harel", "", New DateTime(2019, 1, 2)),
                New UserModel(111, "Shirit", "Maooda", New DateTime(2010, 1, 2)),
                New UserModel(111, "Maayan", "Altman", New DateTime(2013, 1, 2)),
                New UserModel(111, "Uri", "Altman", New DateTime(2014, 1, 2))
            }



            Return View(users) 'go to the view with the same name of the action'
            'Return View("User") 'go to the view with the name "User"'
        End Function

    End Class
End Namespace