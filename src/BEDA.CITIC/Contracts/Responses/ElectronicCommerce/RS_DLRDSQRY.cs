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
    /// 商户退款明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLRDSQRY : RsBase
    {
        /// <summary>
        /// 批次号 varchar(8)
        /// </summary>
        [XmlElement("batNo")]
        public string BatNo { get; set; }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<MerchantCancelDetail> List { get; set; }
    }
    /// <summary>
    /// 商户退款明细
    /// </summary>
    public class MerchantCancelDetail
    {
        /// <summary>
        /// 订单号varchar(40)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 退款流水号varchar(4)
        /// </summary>
        [XmlElement("refundFlwNo")]
        public string RefundFlwNo { get; set; }
        /// <summary>
        /// 商户退款流水号varchar(20)
        /// </summary>
        [XmlElement("cancelFlwNo")]
        public string CancelFlwNo { get; set; }
        /// <summary>
        /// 退款日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlElement("tranDate")]
        public string TranDate { get; set; }
        /// <summary>
        /// 退款时间char(6) 格式hhmmss
        /// </summary>
        [XmlElement("tranTime")]
        public string TranTime { get; set; }
        /// <summary>
        /// 退款时间 由<see cref="TranDate"/>和<see cref="TranTime"/>组成
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
        /// 退款金额 decimal(15,2)
        /// </summary>
        [XmlElement("refundAmt")]
        public decimal RefundAmt { get; set; }
        /// <summary>
        /// 卡号varchar(19)
        /// </summary>
        [XmlElement("cardNo")]
        public string CardNo { get; set; }
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 状态varchar(2)，01：处理中；02：成功；03：失败；04：未知
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
        /// <summary>
        /// 交易状态char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 交易状态描述varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
    }
}
