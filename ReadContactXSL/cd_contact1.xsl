<?xml version='1.0'?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/TR/WD-xsl">
<xsl:template match="/">
  <html>
  <body>
    <table border="2" bgcolor="yellow">
      <tr>
        <th>First Name</th>
        <th>Last Name</th>
      </tr>
      <xsl:for-each select="ContactDatabase/DBinfo/Contact">
      <tr>
        <td><xsl:value-of select="FirstName"/></td>
        <td><xsl:value-of select="LastName"/></td>
      </tr>
      </xsl:for-each>
    </table>
  </body>
  </html>
</xsl:template>
</xsl:stylesheet>