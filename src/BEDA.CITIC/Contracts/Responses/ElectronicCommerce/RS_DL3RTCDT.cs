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
    /// 第三方商户充值退回明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DL3RTCDT : RsBase
    {
        /// <summary>
        /// 批次号 varchar(8)
        /// </summary>
        [XmlElement("batNo")]
        public string BatNo { get; set; }
        
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ThirdPartyRechargeCancelDetail> List { get; set; }
    }
    /// <summary>
    /// 第三方商户充值退回明细
    /// </summary>
    public class ThirdPartyRechargeCancelDetail
    {
        /// <summary>
        /// 订单号varchar(20) 
        /// </summary>
        [XmlElement("orderNo")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 充退日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlElement("tranDate")]
        public string TranDate { get; set; }
        /// <summary>
        /// 充退时间char(6) 格式hhmmss
        /// </summary>
        [XmlElement("tranTime")]
        public string TranTime { get; set; }
        /// <summary>
        /// 充退时间 由<see cref="TranDate"/>和<see cref="TranTime"/>组成
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
        /// 充退制单号 char(20)
        /// </summary>
        [XmlElement("cancelNo")]
        public string CancelNo { get; set; }
        /// <summary>
        /// 商户充值退回流水号varchar(20)
        /// </summary>
        [XmlElement("cancelFlwNo")]
        public string CancelFlwNo { get; set; }
        /// <summary>
        /// 充退金额 decimal(15,2) 
        /// </summary>
        [XmlElement("cancelAmt")]
        public decimal CancelAmt { get; set; }
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccNo")]
        public string PayAccNo { get; set; }
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 交易状态 varchar(2) 值域见附录4.3
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
        /// <summary>
        /// 交易失败状态char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 交易失败状态信息 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
    }
}
