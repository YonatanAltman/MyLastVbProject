@ModelType MyLastVbProject.ProductVM
@Code
    ViewData("Title") = "Create"
End Code

    <style>
        .editor-label{
            margin:10px;
            display:flex;
            justify-content:space-between;
            width :30%;
        }
    </style>

<h2>Create</h2>

@Using (Html.BeginForm("Add", "Product", method:=FormMethod.Post))


    @<div class="form-horizontal">
    <h4>ProductVM</h4>
    <div class="editor-label">
        @Html.DisplayNameFor(Function(model) model.CatalogID)
        @Html.TextBoxFor(Function(model) model.CatalogID, New With {.required = "true"})
    </div>
    <div class="editor-label">
        @Html.DisplayNameFor(Function(model) model.Name)
        @Html.TextBoxFor(Function(model) model.Name)
    </div>
    <div class="editor-label">
        @Html.DisplayNameFor(Function(model) model.Price)
        @Html.TextBox("Price", 1000, New With {.type = "number"})
    </div>
    <div class="editor-label">
        @Html.DisplayNameFor(Function(model) model.IsInStock)
        @Html.CheckBoxFor(Function(model) model.IsInStock)
    </div>
    <div class="editor-label">
        @Html.DisplayNameFor(Function(model) model.Image)
        @Html.TextBoxFor(Function(model) model.Image)
    </div>

    <hr />
  
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Create" class="btn btn-default" />
        </div>
    </div>
</div>
End Using

                <div>
    @Html.ActionLink("Back to List", "Index")
</div>
