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
    /// 指定时间段订单查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DL3RDORD : RsBase
    {
        /// <summary>
        /// 订单查询起始时间 格式YYYYMMDDhhmmss
        /// </summary>
        [XmlIgnore]
        public DateTime QryStartTime { get; set; }
        /// <summary>
        /// 订单查询起始时间 格式YYYYMMDDhhmmss, 对应<see cref="QryStartTime"/>
        /// </summary>
        [XmlElement("qryStartTime")]
        public string QryStartTimeStr
        {
            get
            {
                return this.QryStartTime.ToString("yyyyMMddHHmmss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QryStartTime = tmp;
                }
            }
        }
        /// <summary>
        /// 订单查询截止时间 格式YYYYMMDDhhmmss
        /// </summary>
        [XmlIgnore]
        public DateTime QryEndTime { get; set; }
        /// <summary>
        /// 订单查询截止时间 格式YYYYMMDDhhmmss, 对应<see cref="QryEndTime"/>
        /// </summary>
        [XmlElement("qryEndTime")]
        public string QryEndTimeStr
        {
            get
            {
                return this.QryEndTime.ToString("yyyyMMddHHmmss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QryEndTime = tmp;
                }
            }
        }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ECommerceOrderInfo> List { get; set; }
    }
    /// <summary>
    /// 指定时间段订单信息
    /// </summary>
    public class ECommerceOrderInfo
    {
        /// <summary>
        /// 交易状态 char(7)
        /// </summary>
        [XmlElement("msgCode")]
        public string MsgCode { get; set; }
        /// <summary>
        /// 交易状态信息 varchar(254)
        /// </summary>
        [XmlElement("msgCn")]
        public string MsgCn { get; set; }
        /// <summary>
        /// 订单日期 格式YYYYMMDD
        /// </summary>
        [XmlElement("orderDate")]
        public string OrderDate { get; set; }
        /// <summary>
        /// 订单时间 格式hhmmss
        /// </summary>
        [XmlElement("orderTime")]
        public string OrderTime { get; set; }
        /// <summary>
        /// 订单时间 由<see cref="OrderDate"/>和<see cref="OrderTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? OrderDateTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.OrderDate, this.OrderTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 订单号 char(20)
        /// </summary>
        [XmlElement("orderNo")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 订单金额 decimal(15,2)
        /// </summary>
        [XmlElement("orderAmt")]
        public decimal OrderAmt { get; set; }
        /// <summary>
        /// 支付币种 char(3)
        /// </summary>
        [XmlElement("currId")]
        public string CurrId { get; set; }
        /// <summary>
        /// 支付金额 decimal(15,2)
        /// </summary>
        [XmlElement("payAmt")]
        public decimal PayAmt { get; set; }
        /// <summary>
        /// 摘要信息 char(102)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 支付交易流水号 char(20)
        /// </summary>
        [XmlElement("payNo")]
        public string PayNo { get; set; }
        /// <summary>
        /// 主机操作日期 格式YYYYMMDD
        /// </summary>
        [XmlElement("hostDate")]
        public string HostDate { get; set; }
        /// <summary>
        /// 主机操作时间 时间格式hhmmss
        /// </summary>
        [XmlElement("hostTime")]
        public string HostTime { get; set; }
        /// <summary>
        /// 主机操作时间 由<see cref="HostDate"/>和<see cref="HostTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? HostDateTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.HostDate, this.HostTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 支付卡号 char(19)
        /// </summary>
        [XmlElement("accNo")]
        public string AccNo { get; set; }
        /// <summary>
        /// 卡号类型 char(2) 01：借记卡；02：信用卡
        /// </summary>
        [XmlElement("accType")]
        public string AccType { get; set; }
        /// <summary>
        /// 个人消费者中文姓名 varchar(122)
        /// </summary>
        [XmlElement("pbCstName")]
        public string PbCstName { get; set; }
    }
}
