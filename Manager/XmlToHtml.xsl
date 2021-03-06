<?xml version="1.0" encoding="utf-16"?>
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
          <xsl:for-each select="Stock/videoCard">
          <tr>
            <td>
              <xsl:value-of select ="@Name"/>
            </td>
            <td>
              <xsl:value-of select ="@Chip"/>
            </td>
            <td>
              <xsl:value-of select ="@Memory"/>
            </td>
            <td>
              <xsl:value-of select ="@Type"/>
            </td>
            <td>
              <xsl:value-of select ="@Price"/>
            </td>
            <td>
              <img>
                <xsl:attribute name="src">
                  <xsl:value-of select="@Photo"/>
                </xsl:attribute>
              </img>
            </td>          
          </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
