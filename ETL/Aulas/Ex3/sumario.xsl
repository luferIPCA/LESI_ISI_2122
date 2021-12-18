<?xml version="1.0" encoding="iso-8859-1" ?>
<!--sumario.xsl
	by lufer
-->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="html"/>			
<xsl:template match="sumarios">
	
<html >
	<head >
	<link rel="stylesheet" type="text/css" href="show.css"/>
	<title>Sumarios de <xsl:value-of select="abr"/></title>
	</head>
	<body class="bodyContent">
		<h1><xsl:value-of select="professor/nome"/></h1>
		<h4><xsl:value-of select="professor/email"/></h4>
		<h4><xsl:value-of select="professor/url"/></h4>
		<!-- versao 2
		<xsl:element name="a"><xsl:attribute name="href">mailto:<xsl:value-of select="professor/email"/></xsl:attribute><xsl:value-of select="professor/email"/></xsl:element>
		<xsl:element name="a"><xsl:attribute name="href"><xsl:value-of select="professor/url"/></xsl:attribute><xsl:value-of select="professor/url"/></xsl:element>
		-->
		<h2><xsl:value-of select="disciplina"/></h2>
		<h3><xsl:value-of select="Ano"/></h3>
		<hr/>
		<b>Aulas dadas (<xsl:value-of select="count(/sumarios/aula)"/>) :</b> 
		<a name="topo"/>
		 <xsl:for-each select= "aula">
		 	[<xsl:element name="a">
			<xsl:attribute name="href">#<xsl:value-of select="position()"/>
			</xsl:attribute><xsl:value-of select="position()"/>
			</xsl:element>]
		</xsl:for-each>
		<p/>
		<xsl:call-template name="aulas"/>			
	</body>
</html>
</xsl:template>

<xsl:template name="aulas">
	<xsl:for-each select="aula">
		<!--anchor-->
		<xsl:element name="a"><xsl:attribute name="name"><xsl:value-of select="position()"/></xsl:attribute></xsl:element>
		<table class="content" width="600" border="1" align="center" cellspacing="0" cellpadding="0" >
				<tr> 
					<th width="15%"> Aula <xsl:value-of select="position()"/>
					<xsl:if test="@tipo"> - <xsl:value-of select="@tipo"/></xsl:if></th> 
					<th><xsl:value-of select="data"/></th>
					<th width="5%"><a name="Aula" href="#topo"> ^ </a></th>
				</tr> 
				<tr>
					<td align="center">Sumario:</td>
					<td height="100pt" colspan="2" ><xsl:value-of select="normalize-space(sumario)"/></td>
				</tr>
				<tr> 
					<td>Obs:</td>
					
					<td colspan="2"> 	
						<xsl:if test="string-length(Obs)>0">
						<xsl:element name="a">
								<xsl:attribute name="href"><xsl:value-of select="Obs/File"/></xsl:attribute>
								<xsl:value-of select="Obs/text()"/>
						</xsl:element>
						</xsl:if>
						<xsl:if test="string-length(Obs)=0">
							&#160;
						</xsl:if>
					</td>
				</tr>			
		</table>
		<br/>
	</xsl:for-each>
	
	
</xsl:template>
	
</xsl:stylesheet>
