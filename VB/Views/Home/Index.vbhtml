@Html.DevExpress().NavBar( _
    Sub(navBar)
            navBar.Name = "NavBar"
            navBar.SetGroupContentTemplateContent( _
                Sub(c)
                        Html.DevExpress().TreeView( _
                            Sub(treeView)
                                    treeView.Name = "TreeView" + c.ItemIndex.ToString()
                            End Sub).Bind(New HierarchicalCollectionDataSource(CInt(DataBinder.Eval(c.Group.DataItem, "CategoryId")))).GetHtml()
                End Sub)
    End Sub).Bind(New HierarchicalCollectionDataSource()).GetHtml()