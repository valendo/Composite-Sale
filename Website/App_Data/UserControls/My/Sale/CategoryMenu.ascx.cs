using System;
using Composite.Functions;
using System.Collections.Generic;
using Composite.Data;
using System.Linq;
using System.Text;

public partial class C1Function : Composite.AspNet.UserControlFunction
{
    public override string FunctionDescription
    {
        get
        {
            return "A demo function that outputs a hello message.";
        }
    }

    [FunctionParameter(DefaultValue = "World")]
    public string Name { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        using (DataConnection Data = new DataConnection())
        {
            StringBuilder sb = new StringBuilder();
            var categories = Data.Get<My.Sale.Category>().Where(t => t.Parent == Guid.Empty).ToList();
            RecursiveCategory(categories, ref sb);
            Literal1.Text = sb.ToString();
        }
    }

    public void RecursiveCategory(List<My.Sale.Category> categories, ref System.Text.StringBuilder sb)
    {
        using (DataConnection Data = new DataConnection())
        {
            sb.Append("<ul>");
            foreach (var item in categories)
            {
                sb.AppendFormat("<li><a href='{0}'>{1}</a>", "#", item.CategoryName);
                var subCategories = Data.Get<My.Sale.Category>().Where(t => t.Parent == item.Id).ToList();
                if (subCategories.Count > 0)
                {
                    RecursiveCategory(subCategories, ref sb);
                }
                else
                {
                    sb.Append("</li>");
                }
            }
            sb.Append("</ul>");
        }
    }
}