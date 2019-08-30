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
    /// 上下行短信查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPMMSGQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<MobileInfo> List { get; set; }
    }
    /// <summary>
    /// 上下行短信信息
    /// </summary>
    public class MobileInfo
    {
        /// <summary>
        /// 中信短信服务号 varchar(11)
        /// </summary>
        [XmlElement("citicMobile")]
        public string CiticMobile { get; set; }
        /// <summary>
        /// 付款客户手机号 varchar(11)
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 短信内容
        /// </summary>
        [XmlElement("msgContent")]
        public string MsgContent { get; set; }
        /// <summary>
        /// 订单号 varchar(20)
        /// </summary>
        [XmlElement("orderNo")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 处理日期 varchar(10)
        /// </summary>
        [XmlElement("prcDate")]
        public string PrcDate { get; set; }
        /// <summary>
        /// 处理时间 varchar(8)
        /// </summary>
        [XmlElement("prcTime")]
        public string PrcTime { get; set; }
        /// <summary>
        /// 处理时间 由<see cref="PrcDate"/>和<see cref="PrcTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? ProcessingTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.PrcDate, this.PrcTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss","yyyy-MM-ddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 短信流水号 varchar(20)
        /// </summary>
        [XmlElement("smsFlowNo")]
        public string SmsFlowNo { get; set; }
        /// <summary>
        /// 短信状态 0：未处理；1：已处理 char(1)
        /// </summary>
        [XmlElement("smsStt")]
        public int SmsStt { get; set; }
        /// <summary>
        /// 短信类型 0：上行；1：下行 char(1)
        /// </summary>
        [XmlElement("smsType")]
        public int SmsType { get; set; }
        /// <summary>
        /// 发送日期 varchar(10)
        /// </summary>
        [XmlElement("subDate")]
        public string SubDate { get; set; }
        /// <summary>
        /// 发送时间 varchar(8)
        /// </summary>
        [XmlElement("subTime")]
        public string SubTime { get; set; }
        /// <summary>
        /// 发送时间 由<see cref="SubDate"/>和<see cref="SubTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? SendTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.SubDate, this.SubTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss", "yyyy-MM-ddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 短信类型 0：主动付款；1：订单付款；2：订单通知；3：签约通知；
        /// </summary>
        [XmlElement("txtType")]
        public int TxtType { get; set; }
    }
}