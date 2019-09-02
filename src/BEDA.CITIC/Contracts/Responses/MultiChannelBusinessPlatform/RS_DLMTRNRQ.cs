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
    /// 交易结果查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLMTRNRQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<OrderTransactionInfo> List { get; set; }
    }
    /// <summary>
    /// 交易结果
    /// </summary>
    public class OrderTransactionInfo
    {
        /// <summary>
        /// 人行、银联标识 空： 签收订单；0000：人行；其他4位代码：银联
        /// </summary>
        [XmlElement("areaCode")]
        public string AreaCode { get; set; }
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }
        /// <summary>
        /// 订单号 varchar(20)
        /// </summary>
        [XmlElement("orderNo")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 订单支付币种01
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }
        /// <summary>
        /// 付方账号
        /// </summary>
        [XmlElement("payAccNo")]
        public string PayAccNo { get; set; }
        /// <summary>
        /// 收方账号
        /// </summary>
        [XmlElement("rcvAccNo")]
        public string RcvAccNo { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 付方手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 交易日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlElement("tranDate")]
        public string TranDate { get; set; }
        /// <summary>
        /// 交易时间 char(6) 格式hhmmss
        /// </summary>
        [XmlElement("tranTime")]
        public string TranTime { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="TranDate"/>和<see cref="TranTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TranDate, this.TranTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 清算日期
        /// </summary>
        [XmlIgnore]
        public DateTime RecdDate { get; set; }
        /// <summary>
        /// 清算日期, 对应<see cref="RecdDate"/>
        /// </summary>
        [XmlElement("recdDate")]
        public string StartDateStr
        {
            get
            {
                return this.RecdDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RecdDate = tmp;
                }
            }
        }
        /// <summary>
        /// NCR客户代码
        /// </summary>
        [XmlElement("payUserId")]
        public string PayUserId { get; set; }
        /// <summary>
        /// 客户名称varchar(122)
        /// </summary>
        [XmlElement("payCstName")]
        public string PayCstName { get; set; }
        /// <summary>
        /// 交易状态	1：发送中；2：发送超时；3：交易成功；4：交易失败；5：清算成功；6：清算失败；7：已确认
        /// </summary>
        [XmlElement("tranStt")]
        public int TranStt { get; set; }
        /// <summary>
        /// 摘要varchar(102)
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("retCode")]
        public string RetCode { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("flowNo")]
        public string FlowNo { get; set; }
    }
}