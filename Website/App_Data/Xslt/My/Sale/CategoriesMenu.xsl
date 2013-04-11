<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:in="http://www.composite.net/ns/transformation/input/1.0" xmlns:lang="http://www.composite.net/ns/localization/1.0" xmlns:f="http://www.composite.net/ns/function/1.0" xmlns="http://www.w3.org/1999/xhtml" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:csharp="http://c1.composite.net/sample/csharp" exclude-result-prefixes="xsl in lang f msxsl csharp">
	<xsl:param name="categories" select="/in:inputs/in:result[@name='GetCategoryXml']/Category" />
	<xsl:template match="/">
		<html>
			<head>
				<!-- markup placed here will be shown in the head section of the rendered page -->
			</head>
			<body>
				<xsl:value-of select="csharp:GetMenu()" disable-output-escaping="yes"/>
			</body>
		</html>
	</xsl:template>
	<msxsl:script implements-prefix="csharp" language="C#">
		<msxsl:assembly name="System.Core" />
		<msxsl:assembly name="System.Xml.Linq" />
		<msxsl:assembly name="Composite" />
		<msxsl:assembly name="Composite.Generated" />
		<msxsl:using namespace="System.Collections.Generic" />
		<msxsl:using namespace="System.Linq" />
		<msxsl:using namespace="System.Xml.Linq" />
		<msxsl:using namespace="Composite.Data" /><![CDATA[
		  public string GetMenu()
		  {
        StringBuilder sb = new StringBuilder();
        using (DataConnection Data = new DataConnection())
        {
            var categories = Data.Get<My.Sale.Category>().Where(t => t.Parent == Guid.Empty).ToList();
            RecursiveCategory(categories, ref sb);
        }
        return sb.ToString();
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
                  sb.Append("</li>");
              }
              sb.Append("</ul>");
          }
      }
	]]></msxsl:script>
</xsl:stylesheet>