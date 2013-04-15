<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:in="http://www.composite.net/ns/transformation/input/1.0"
  xmlns:lang="http://www.composite.net/ns/localization/1.0"
  xmlns:f="http://www.composite.net/ns/function/1.0"
  xmlns="http://www.w3.org/1999/xhtml"
  exclude-result-prefixes="xsl in lang f">

	<xsl:param name="sitemap" select="/in:inputs/in:result[@name='SitemapXml']/Page" />

	<xsl:template match="/">
		<html>
			<head>
			</head>

			<body>
				<div id="tab_nav">
				<!--<div class="top-nav-left"></div>-->
					<div class="top-nav-right"></div>
					<ul class="list-style-none">
						<li class="home-link"><a href="/">Home</a></li>
						<xsl:for-each select="$sitemap[@isopen='true']">
							<xsl:apply-templates select="Page" />
						</xsl:for-each>
					</ul>
				</div>
			</body>
		</html>
	</xsl:template>

	<xsl:template match="Page">
		<xsl:if test="count(@MenuTitle)">
			<li>
				<xsl:if test="@isopen='true'" >
					<xsl:attribute name="id">tab_active</xsl:attribute>
				</xsl:if>
				<a href="{@URL}">
				<xsl:value-of select="@MenuTitle" />
				</a></li>
		</xsl:if>
	</xsl:template>
</xsl:stylesheet>
