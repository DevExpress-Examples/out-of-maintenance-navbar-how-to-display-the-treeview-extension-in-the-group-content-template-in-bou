using System.Web.UI;
using System.Collections.Generic;

public class HierarchicalCollectionDataSource : HierarchicalDataSourceControl, IHierarchicalDataSource {
    private int rootCategoryId;

    public HierarchicalCollectionDataSource(int rootCategoryId = 0) {
        this.rootCategoryId = rootCategoryId;
    }

    protected override HierarchicalDataSourceView GetHierarchicalView(string viewPath) {
        return new HierarchicalCollectionDataSourceView(rootCategoryId);
    }
}

public class HierarchicalCollectionDataSourceView : HierarchicalDataSourceView {
    private int rootCategoryId;

    public HierarchicalCollectionDataSourceView(int rootCategoryId) {
        this.rootCategoryId = rootCategoryId;
    }

    public override IHierarchicalEnumerable Select() {
        CategoryHierarchicalEnumerable collection = new CategoryHierarchicalEnumerable();

        foreach (Category category in CategoriesDataProvider.GetCategoryData()) {
            if (category.ParentId == rootCategoryId)
                collection.Add(category);
        }

        return collection;
    }
}

public class CategoryHierarchicalEnumerable : List<Category>, IHierarchicalEnumerable {
    public IHierarchyData GetHierarchyData(object enumeratedItem) {
        return enumeratedItem as IHierarchyData;
    }
}

public class Category : IHierarchyData {
    public int CategoryId { get; set; }
    public int ParentId { get; set; }
    public string Name { get; set; }

    public Category(int CategoryId, int ParentId, string Name) {
        this.CategoryId = CategoryId;
        this.ParentId = ParentId;
        this.Name = Name;
    }

    public IHierarchicalEnumerable GetChildren() {
        CategoryHierarchicalEnumerable children = new CategoryHierarchicalEnumerable();

        foreach (Category category in CategoriesDataProvider.GetCategoryData()) {
            if (category.ParentId == this.CategoryId) {
                children.Add(category);
            }
        }

        return children;

    }

    public IHierarchyData GetParent() {
        foreach (Category category in CategoriesDataProvider.GetCategoryData()) {
            if (category.CategoryId == this.ParentId)
                return category;
        }

        return null;
    }

    public bool HasChildren {
        get {
            List<Category> children = GetChildren() as List<Category>;
            return children.Count > 0;
        }
    }

    public object Item {
        get { return this; }
    }

    public string Path {
        get { return this.CategoryId.ToString(); }
    }

    public string Type {
        get { return this.GetType().ToString(); }
    }

    public override string ToString() {
        return this.Name;
    }
}