<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:in="http://www.composite.net/ns/transformation/input/1.0" xmlns:lang="http://www.composite.net/ns/localization/1.0" xmlns:f="http://www.composite.net/ns/function/1.0" xmlns="http://www.w3.org/1999/xhtml" exclude-result-prefixes="xsl in lang f">
	<xsl:template match="/">
		<html>
			<head>
				<xsl:for-each select="/in:inputs/in:result[@name='GetSEOPageInfoXml']/SEOPageInfo" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
					<meta name="keywords" content="{@Keywords}"/>
				</xsl:for-each>
			</head>
			<body>
				
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>