<xsl:transform
        version="1.0"
        xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
        xmlns:myCustDate="urn:custDate">
<xsl:output method="text" omit-xml-declaration="yes" />		
<xsl:template name="DataType">
	<xsl:param name="x"/>
	<xsl:if test="dataType[.='varchar']">string </xsl:if>
	<xsl:if test="dataType[.='char']">string </xsl:if>
	<xsl:if test="dataType[.='nvarchar']">string </xsl:if>
	<xsl:if test="dataType[.='ntext']">string </xsl:if>	
	<xsl:if test="dataType[.='int']">int </xsl:if>
	<xsl:if test="dataType[.='float']">decimal </xsl:if>
	<xsl:if test="dataType[.='double']">decimal </xsl:if>
	<xsl:if test="dataType[.='decimal']">decimal </xsl:if>	
	<xsl:if test="dataType[.='datetime']">DateTime? </xsl:if>
	<xsl:if test="dataType[.='bit']">bool </xsl:if>
	<xsl:if test="dataType[.='bigint']">long </xsl:if>
</xsl:template>
<xsl:template name="initCap">
  <xsl:param name="x"/>
  <xsl:value-of select="translate(substring($x,1,1),'abcdefghijklmnopqrstuvwxyz','ABCDEFGHIJKLMNOPQRSTUVWXYZ')"/>
  <xsl:value-of select="substring($x,2)"/>
</xsl:template>
	<xsl:template match="Table">
using System;
namespace BMS.Model
{
	public partial class <xsl:value-of select="./name"/>Model : BaseModel
	{<!-- <xsl:for-each select="/Table/column"> -->
		<!-- private <xsl:call-template name="DataType"><xsl:with-param name="x" select="./dataType"/></xsl:call-template> <xsl:value-of select="./name"/>;</xsl:for-each> -->	
		
	<xsl:for-each select="/Table/column">
		public <xsl:call-template name="DataType"><xsl:with-param name="x" select="./dataType"/></xsl:call-template> <xsl:call-template name="initCap"><xsl:with-param name="x" select="./name"/></xsl:call-template> {get; set;}
		<!-- {
			get { return <xsl:value-of select="./name"/>; }
			set { <xsl:value-of select="./name"/> = value; }
		} -->
	</xsl:for-each>
	}
}
	</xsl:template>
</xsl:transform>