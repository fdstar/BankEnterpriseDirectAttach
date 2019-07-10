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
    /// 支付业务协议查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPTLPHT : RsBase
    {
        /// <summary>
        /// 总记录条数 int
        /// </summary>
        [XmlElement("totalRecords")]
        public int TotalRecords { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<InterBankPaymentProtocol> List { get; set; }
    }
    /// <summary>
    /// 支付业务协议
    /// </summary>
    public class InterBankPaymentProtocol
    {
        /// <summary>
        /// 协议编号varchar(60)
        /// </summary>
        [XmlElement("ptcID")]
        public string PtcID { get; set; }
        /// <summary>
        /// 付款机构号varchar(20)
        /// </summary>
        [XmlElement("payAccBankNo")]
        public string PayAccBankNo { get; set; }
        /// <summary>
        /// 付款机构名称varchar(122)
        /// </summary>
        [XmlElement("payAccBankNm")]
        public string PayAccBankNm { get; set; }
        /// <summary>
        /// 付款账户名称varchar(122)
        /// </summary>
        [XmlElement("payAccNm")]
        public string PayAccNm { get; set; }
        /// <summary>
        /// 付款账号varchar(32)
        /// </summary>
        [XmlElement("payAccNo")]
        public string PayAccNo { get; set; }
        /// <summary>
        /// 收款机构号 varchar(20)
        /// </summary>
        [XmlElement("recAccBankNo")]
        public string RecAccBankNo { get; set; }
        /// <summary>
        /// 收款机构名称 varchar(122)
        /// </summary>
        [XmlElement("recAccBankNm")]
        public string RecAccBankNm { get; set; }
        /// <summary>
        /// 收款账号varchar(32)
        /// </summary>
        [XmlElement("rceAccNo")]
        public string RceAccNo { get; set; }
        /// <summary>
        /// 收款账户名称varchar(122)
        /// </summary>
        [XmlElement("rceAccNm")]
        public string RceAccNm { get; set; }
        /// <summary>
        /// 单笔金额上限decimal(15,2)
        /// </summary>
        [XmlElement("sinAmtLimit")]
        public decimal SinAmtLimit { get; set; }
        /// <summary>
        /// 日累计金额上限decimal(15,2)
        /// </summary>
        [XmlElement("dayAmtLimit")]
        public decimal DayAmtLimit { get; set; }
        /// <summary>
        /// 月累计金额上限decimal(15,2)
        /// </summary>
        [XmlElement("monthAmtLimit")]
        public decimal MonthAmtLimit { get; set; }
        /// <summary>
        /// 支付业务种类varchar(5) 详见附录4.7
        /// </summary>
        [XmlElement("payBsnType")]
        public string PayBsnType { get; set; }
        /// <summary>
        /// 客户服务号varchar(60)
        /// </summary>
        [XmlElement("serviceNo")]
        public string ServiceNo { get; set; }
        /// <summary>
        /// 生效日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime EffDate { get; set; }
        /// <summary>
        /// 生效日期 char(8), 对应<see cref="EffDate"/>
        /// </summary>
        [XmlElement("effDate")]
        public string EffDateStr
        {
            get
            {
                return this.EffDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EffDate = tmp;
                }
            }
        }
        /// <summary>
        /// 失效日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime ExDate { get; set; }
        /// <summary>
        /// 失效日期 char(8), 对应<see cref="ExDate"/>
        /// </summary>
        [XmlElement("exDate")]
        public string ExDateStr
        {
            get
            {
                return this.ExDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ExDate = tmp;
                }
            }
        }
        /// <summary>
        /// 协议状态 char(2) 附录4.6
        /// </summary>
        [XmlElement("ptcStt")]
        public string PtcStt { get; set; }
        /// <summary>
        /// 签约日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime PtcDate { get; set; }
        /// <summary>
        /// 签约日期char(8) 格式YYYYMMDD, 对应<see cref="PtcDate"/>
        /// </summary>
        [XmlElement("ptcDate")]
        public string PtcDateStr
        {
            get
            {
                return this.PtcDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PtcDate = tmp;
                }
            }
        }
    }
}
