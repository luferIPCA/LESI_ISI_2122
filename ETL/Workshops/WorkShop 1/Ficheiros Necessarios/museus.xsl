<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns="http://www.w3.org/1999/xhtml">
<xsl:output method="xml" indent="yes" encoding="UTF-8"/>
<xsl:template match="/museums">
 <html>
      <head> <title>Museums</title> </head>
      <body>
        <h1>Museum</h1>
        <table border="1">
        <tr bgcolor="lightblue"><td>Name</td><td>City</td><td>Country</td><td>Temperature</td><td>Visibility</td><td>Wind</td></tr>
          <xsl:apply-templates select="museum">
            <xsl:sort select="name" />
          </xsl:apply-templates>
        </table>
      </body>
    </html>
  </xsl:template>
 <xsl:template match="museum">
    <tr>
      <td><xsl:value-of select="name"/></td>
      <td><xsl:value-of select="city"/></td>
      <td><xsl:value-of select="country"/></td>
      <td><xsl:value-of select="Temperature"/></td>
      <td><xsl:value-of select="Visibility"/></td>
      <td><xsl:value-of select="Wind"/></td>
    </tr>
  </xsl:template>
</xsl:stylesheet>
