Public Class Product
    Public CatalogID As String
    Public Name As String
    Public Price As Double
    Public IsInStock As Boolean
    Public Image As String
    Public CreateDate As DateTime
    Public NotImportentData As String

    Sub New()

        Me.CreateDate = New Date()
        Me.NotImportentData = "Do Not Display!"

    End Sub
    Sub New(
        catalogID As String,
        name As String,
        price As Double,
        IsInStock As Boolean,
        Image As String
        )
        Me.CatalogID = catalogID
        Me.Name = name
        Me.Price = price
        Me.IsInStock = IsInStock
        Me.Image = Image
        Me.CreateDate = New Date()
        Me.NotImportentData = "Do Not Display!"

    End Sub
End Class
