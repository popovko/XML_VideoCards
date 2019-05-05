<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>

   <xsl:output method="html"/>
    <xsl:template match="/">
        <html>
          <body> 
            <table border ="1">                     
          <TR>
            <th>Name</th>
            <th>Chip</th>
            <th>Memory</th>
            <th>Type</th>
            <th>Price</th>
            <th>Photo</th>
          </TR>  
              <tr>
              <xsl:for-each select="Stock/vodeoCard"/>
                </tr>
            <tr>
              <th ><xsl:value-of select ="@Name"/></th>
              <td> <xsl:value-of select ="Stock/vodeoCard/Chip"/> </td>
              <td> <xsl:value-of select ="Stock/vodeoCard[@Memory]"/> </td>
              <td> <xsl:value-of select ="Stock/vodeoCard[@Type]"/> </td>
              <td> <xsl:value-of select ="Stock/vodeoCard[@Price]"/> </td>
              <td> <xsl:value-of select ="Stock/vodeoCard[@Photo]"/> </td>
            </tr>
          </table>
          </body>
        </html>
    </xsl:template>            
</xsl:stylesheet>
