using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 借款企业额度查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCLCRTQ : RsBase
    {
        /// <summary>
        /// 企业端经销商客户代码 varchar(20)
        /// </summary>
        [XmlElement("cpCustCd")]
        public string CpCustCd { get; set; }
        /// <summary>
        /// 银行端借款企业id varchar(20)
        /// </summary>
        [XmlElement("bkCustCd")]
        public string BkCustCd { get; set; }
        /// <summary>
        /// 借款企业名称 varchar(122)
        /// </summary>
        [XmlElement("lonCpNm")]
        public string LonCpNm { get; set; }
        /// <summary>
        /// 额度记录数varchar(2)
        /// </summary>
        [XmlElement("creditCt")]
        public string CreditCt { get; set; }
        /// <summary>
        /// 属性4 varchar(30) ，按约定返回
        /// </summary>
        [XmlElement("field4")]
        public string Field4 { get; set; }
        /// <summary>
        /// 属性5 varchar(60) ，按约定返回
        /// </summary>
        [XmlElement("field5")]
        public string Field5 { get; set; }
        /// <summary>
        /// 属性6 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field6")]
        public string Field6 { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<EnterpriseLoanLimit> List { get; set; }
    }
    /// <summary>
    ///  借款企业额度
    /// </summary>
    public class EnterpriseLoanLimit
    {
        /// <summary>
        /// 企业端经销商客户代码 varchar(20)
        /// </summary>
        [XmlElement("cpCustCd")]
        public string CpCustCd { get; set; }
        /// <summary>
        /// 银行端借款企业id varchar(20),可空
        /// </summary>
        [XmlElement("bkCustCd")]
        public string BkCustCd { get; set; }
        /// <summary>
        /// 借款企业名称 varchar(122)
        /// </summary>
        [XmlElement("lonCpNm")]
        public string LonCpNm { get; set; }
        /// <summary>
        /// 品牌编码 varchar(20)
        /// </summary>
        [XmlElement("brandCd")]
        public string BrandCd { get; set; }
        /// <summary>
        /// 品牌名称 varchar(100)
        /// </summary>
        [XmlElement("brandNm")]
        public string BrandNm { get; set; }
        /// <summary>
        /// 经办分行编号 varchar(20)
        /// </summary>
        [XmlElement("opBrhCd")]
        public string OpBrhCd { get; set; }
        /// <summary>
        /// 经办分行名称 varchar(122)
        /// </summary>
        [XmlElement("opBrhNm")]
        public string OpBrhNm { get; set; }
        /// <summary>
        /// 额度编号 varchar(20)
        /// </summary>
        [XmlElement("creditNo")]
        public string CreditNo { get; set; }
        /// <summary>
        /// 额度协议文本号 varchar(60)
        /// </summary>
        [XmlElement("crdtAgtNo")]
        public string CrdtAgtNo { get; set; }
        /// <summary>
        /// 授信币种 varchar(2)
        /// </summary>
        [XmlElement("crdtCcy")]
        public string CrdtCcy { get; set; }
        /// <summary>
        /// 总额度 decimal(19,2)
        /// </summary>
        [XmlElement("totCrd")]
        public decimal TotCrd { get; set; }
        /// <summary>
        /// 总敞口 decimal(19,2)
        /// </summary>
        [XmlElement("totExp")]
        public decimal TotExp { get; set; }
        /// <summary>
        /// 可用额度 decimal(19,2)
        /// </summary>
        [XmlElement("aldCrd")]
        public decimal AldCrd { get; set; }
        /// <summary>
        /// 可用敞口 decimal(19,2)
        /// </summary>
        [XmlElement("aldExp")]
        public decimal AldExp { get; set; }
        /// <summary>
        /// 额度合同开始日期  char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime CrdStDt { get; set; }
        /// <summary>
        /// 额度合同开始日期  char(8)，格式YYYYMMDD, 对应<see cref="CrdStDt"/>
        /// </summary>
        [XmlElement("crdStDt")]
        public string CrdStDtStr
        {
            get
            {
                return this.CrdStDt.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CrdStDt = tmp;
                }
            }
        }
        /// <summary>
        /// 额度合同结束日期  char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime CrdEdDt { get; set; }
        /// <summary>
        /// 额度合同结束日期  char(8)，格式YYYYMMDD, 对应<see cref="CrdEdDt"/>
        /// </summary>
        [XmlElement("crdEdDt")]
        public string LonMatrtStr
        {
            get
            {
                return this.CrdEdDt.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CrdEdDt = tmp;
                }
            }
        }
        /// <summary>
        /// 属性7 varchar(30) ，按约定返回
        /// </summary>
        [XmlElement("field7")]
        public string Field7 { get; set; }
        /// <summary>
        /// 属性8 varchar(60) ，按约定返回
        /// </summary>
        [XmlElement("field8")]
        public string Field8 { get; set; }
        /// <summary>
        /// 属性9 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field9")]
        public string Field9 { get; set; }
    }
}
