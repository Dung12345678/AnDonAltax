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
	<xsl:if test="dataType[.='float']">double </xsl:if>
	<xsl:if test="dataType[.='double']">double </xsl:if>
	<xsl:if test="dataType[.='decimal']">Decimal </xsl:if>	
	<xsl:if test="dataType[.='datetime']">DateTime </xsl:if>
	<xsl:if test="dataType[.='bit']">Byte </xsl:if>
	<xsl:if test="dataType[.='bigint']">long </xsl:if>
</xsl:template>
<xsl:template name="initCap">
  <xsl:param name="x"/>
  <xsl:value-of select="translate(substring($x,1,1),'abcdefghijklmnopqrstuvwxyz','ABCDEFGHIJKLMNOPQRSTUVWXYZ')"/>
  <xsl:value-of select="substring($x,2)"/>
</xsl:template>
<xsl:template match="Table">
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	<xsl:variable name="tableName" select="./name"/>
	public class <xsl:value-of select="./name"/>BO : BaseBO
	{
		private <xsl:value-of select="./name"/>Facade facade = <xsl:value-of select="./name"/>Facade.Instance;
		protected static <xsl:value-of select="./name"/>BO instance = new <xsl:value-of select="./name"/>BO();

		protected <xsl:value-of select="./name"/>BO()
		{
			this.baseFacade = facade;
		}

		public static <xsl:value-of select="./name"/>BO Instance
		{
			get { return instance; }
		}
		
	<xsl:for-each select="/Table/column">
		<xsl:if test="isFK[.='true']">
		public ArrayList FindBy<xsl:value-of select="./name"/>(<xsl:call-template name="DataType"><xsl:with-param name="x" select="./dataType"/></xsl:call-template> <xsl:value-of select="./name"/>)
		{
			return facade.FindBy<xsl:call-template name="initCap"><xsl:with-param name="x" select="./name"/></xsl:call-template>(<xsl:value-of select="./name"/>);
		}

		</xsl:if>
		<xsl:if test="isUnique[.='true']">
		public <xsl:value-of select="$tableName"/>Model FindBy<xsl:call-template name="initCap"><xsl:with-param name="x" select="./name"/></xsl:call-template>(<xsl:call-template name="DataType"><xsl:with-param name="x" select="./dataType"/></xsl:call-template> <xsl:value-of select="./name"/>)
		{
			try
			{
				return facade.FindBy<xsl:call-template name="initCap"><xsl:with-param name="x" select="./name"/></xsl:call-template>(<xsl:value-of select="./name"/>);
			}
			catch (Exception e)
			{
				throw new BOException(e.Message);
			}
		}
		</xsl:if>
	</xsl:for-each>
	}
}
	</xsl:template>
</xsl:transform>		
