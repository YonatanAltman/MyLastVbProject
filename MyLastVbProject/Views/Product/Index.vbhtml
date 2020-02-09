@ModelType IEnumerable(Of ProductVM)
@Code
    ViewData("Title") = "Index"
End Code

<!DOCTYPE html>

<html>
<head>
    <style>
        img {
            height : 100px
        }
    </style>
</head>
<body>
    <h2>List</h2>

    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.CatalogID)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Name)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Price)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Image)
            </th>

            <th>Actions</th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.CatalogID)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Name)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Price)
                </td>
                <td>
                    <img src="@Html.DisplayFor(Function(modelItem) item.Image)" 
                         alt="@Html.DisplayFor(Function(modelItem) item.CatalogID)" />
                </td>

                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.CatalogID}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.CatalogID})
                </td>
            </tr>
        Next

    </table>

</body>
</html>
