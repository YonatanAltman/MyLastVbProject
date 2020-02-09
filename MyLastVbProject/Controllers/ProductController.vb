Imports System.Web.Mvc
Imports BL
Imports Entities

Namespace Controllers
    Public Class ProductController
        Inherits Controller

        ' GET: Product
        Function Index() As ActionResult

            Dim manager = New ProductManager()
            Dim products = manager.GetAll()
            Dim product = manager.GetProduct("150-epr")
            Dim productsVm = ConvertProductToVm(products)
            ' Return Json(products, JsonRequestBehavior.AllowGet)
            Return View(productsVm)
        End Function
        Function Create() As ActionResult



            Return View()

        End Function




        <HttpPost()>
        Function Add(Product As ProductVM) As ActionResult

            Dim p = Product

            Return View("Index")

        End Function




        Private Function ConvertProductToVm(products As List(Of Product)) As List(Of ProductVM)
            Dim arr = New List(Of ProductVM)()
            For Each p In products
                arr.Add(New ProductVM(p.CatalogID, p.Name, p.Price, p.IsInStock, p.Image))
            Next

            Return arr
        End Function

    End Class
End Namespace