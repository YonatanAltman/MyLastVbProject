Imports Entities

Public Class ProductManager
    Private ProductList As New List(Of Product) From {
        New Product("123-epr", "Samsung Galaxy S10 Plus", 1500, True, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png"),
        New Product("142-epr", "iPhone 11", 1670, True, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/i/p/iphone_11_pro_s_2.png"),
        New Product("144-epr", "Samsung Galaxy Note 10 Plus", 1200, True, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/8/_/8_1.png"),
        New Product("147-epr", "iPhone 11 Pro Max", 2100, True, "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/iphone-11-pro-select-2019-family?wid=441&amp;hei=529&amp;fmt=jpeg&amp;qlt=95&amp;op_usm=0.5,0.5&amp;.v=1567812930312"),
        New Product("148-epr", "Samsung Galaxy S10e", 2066, True, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10e-black-angle_2.png"),
        New Product("150-epr", "OnePlus 7 Pro", 1800, True, "https://image01.oneplus.net/ebp/201904/29/122/d36a14233fc973a4c012d6e369b1821c.png"),
        New Product("152-epr", "Google Pixel 4 XL", 3000, True, "https://cdn.tmobile.com/content/dam/t-mobile/en-p/cell-phones/Google/Google-Pixel-4-XL/Just-Black/Google-Pixel-4-XL-Just-Black-frontimage.jpg"),
        New Product("153-epr", "Huawei P30 Pro", 2550, True, "https://static-www.o2.co.uk/sites/default/files/huawei-p30-pro-aurora-sku-header-180319.png"),
        New Product("156-epr", "Samsung Galaxy S10", 1510, True, "https://ss7.vzw.com/is/image/VerizonWireless/SamsungGalaxyS10_Blue?$png8alpha256$&hei=520"),
        New Product("157-epr", "iPhone XR", 2000, True, "https://images.macrumors.com/t/OzAj4wUmCpwhzkH9KMOfbXK1Y9Q=/400x0/article-new/2018/09/littleiphonexr.jpg"),
        New Product("159-epr", "iPhone XS", 2100, True, "https://www.idigital.co.il/files/iPhone_XS/shop_product/iPhoneXs-Family-3Up-Angled-US-EN-SCREEN.png"),
        New Product("160-epr", "Google Pixel 3 XL", 1900, True, "https://fdn2.gsmarena.com/vv/pics/google/google-pixel-3xl-4.jpg")
    }


    Sub New()

    End Sub

    Function GetAll() As List(Of Product)
        Return ProductList
    End Function
    Function GetProduct(catalogId As String) As Product
        Return ProductList.Find(Function(p) p.CatalogID = catalogId)

    End Function

End Class
