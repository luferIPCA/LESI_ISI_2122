<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns="http://www.w3.org/1999/xhtml">
<xsl:output method="xml" indent="yes" encoding="UTF-8"/>
<xsl:template match="/Companies">
 <html>
      <head> 
        <style>

        .chart div {
            font: 10px sans-serif;
            text-align: right;
            padding: 3px;
            margin: 1px;
            color: white;
            margin-left: 20px;
        }

        </style>
        <title>Stock Quotes od Facebook and Alibaba</title> 
      </head>
      <body>
        <h1>Companies</h1>
        <div class="chart">
          <xsl:apply-templates select="Company">
            <xsl:sort select="Name" />
          </xsl:apply-templates>
        </div>
        <p><span style="font-size: 10px; line-height: 1px">&#160;&#160; Caption: <span style="color:#160949">&#9830;</span> - Previous Close - Previous close can refer to the prior day's value of a stock, bond, commodity, futures or option contract, market index, or any other security</span></p>
        <p><span style="font-size: 10px; line-height: 1px">&#160;&#160; Caption: <span style="color:#2B1C67">&#9830;</span> - Open - The open on a trading exchange signals the start of an official day for the exchange, and that buy and sell transactions can commence for the business day.</span></p>
        <p><span style="font-size: 10px; line-height: 1px">&#160;&#160; Caption: <span style="color:#40317F">&#9830;</span> - Last -  Last-traded price and volume traded</span></p>
        <p><span style="font-size: 10px; line-height: 1px">&#160;&#160; Caption: <span style="color:#40317F">&#9830;</span> - High - The highest and lowest prices that a stock has traded at during the previous year</span></p>
        <p><span style="font-size: 10px; line-height: 1px">&#160;&#160; Caption: <span style="color:#40317F">&#9830;</span> - Low - The highest and lowest prices that a stock has traded at during the previous year</span></p>
        <p></p>
        <h3>Objectivo</h3>
        <p>O objectivo deste Workshop consiste em ter uma execu????o di??ria, em que notifique os clientes por email com as cota????es das suas ac????es das empresas cotadas no NASDAQ.</p>
        <h3>Tecnologias Usadas</h3>
        <p>As tecnologias que ir??o ser utilizadas ir??o ser xml, dtd e xsl</p>
        <h3>Descri????o</h3>
        <p>Em anexo encontra-se todos os ficheiros necess??rios para este workshop:</p>
        <ul>
            <li>load_job.kjb - Job principal que t??m toda a cadeia de transforma????es</li>
            <li>get_stock.ktr - Transforma????o que utiliza we service para saber as cota????es de mercado</li>
            <li>parseToString.ktr - Transforma????o que coloca todo o c??digo html numa string para ser injectado no corpo de email</li>
            <li>StockCompanies.xml - XML file onde se configura as empresas para obter a cotiza????o de mercado</li>
            <li>finalCompaniesXml.xml - XML file final onde s??o incluidos os dados da cotiza????o</li>
            <li>CompaniesDTD.dtd - DTD file de valida????o do xml</li>
            <li>template.xsl - Style sheet para a cria????o do email</li>
        </ul>
        <h4>Email gerado por Pentaho Data Integration Kettle</h4>
        <h4>Autor: Daniel Salgueiral</h4>
      </body>
    </html>
  </xsl:template>
 <xsl:template match="Company">
  <h2><xsl:value-of select="Name"/></h2>
   <div style="width:{PreviousClose}px; background-color: #160949;"><xsl:value-of select="PreviousClose"/></div>
   <div style="width:{Open}px; background-color: #2B1C67;"><xsl:value-of select="Open"/></div>
   <div style="width:{Last}px; background-color: #40317F;"><xsl:value-of select="Last"/></div>
   <div style="width:{High}px; background-color: #5B4C96;"><xsl:value-of select="High"/></div>
   <div style="width:{Low}px; background-color: #8276B3;"><xsl:value-of select="Low"/></div>
    <xsl:choose>
        <xsl:when test="Change = 0">
          <div style= "text-align: left; font: 13px sans-serif;">Change Trend - &#8594;  <xsl:value-of select="Change"/></div>
        </xsl:when>
        <xsl:when test="Change &gt; 0">
          <div style="color: green; text-align: left; font: 13px sans-serif;">Change Trend - &#8593;  <xsl:value-of select="Change"/></div>
        </xsl:when>
        <xsl:otherwise>
          <div style="color: red; text-align: left; font: 13px sans-serif;">Change Trend - &#8595;  <xsl:value-of select="Change"/></div>
        </xsl:otherwise>
      </xsl:choose>
  </xsl:template>
</xsl:stylesheet>