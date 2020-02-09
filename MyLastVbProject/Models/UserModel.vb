Public Class UserModel
    Private _id As Integer
    Private _firstName As String
    Private _lastName As String
    Private _date As DateTime


    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return _firstName

        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return _lastName

        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Public Property StartDate() As DateTime
        Get
            Return _date
        End Get
        Set(ByVal value As DateTime)
            _date = value
        End Set
    End Property
    Public Sub New(ByVal id As Integer, ByVal firstName As String, ByVal lastName As String, ByVal startDate As DateTime)
        ' Initialize with a specific course in mind
        Me.ID = id
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.StartDate = startDate



    End Sub
    Public Sub New()
        ' Initialize without a course
    End Sub
End Class
