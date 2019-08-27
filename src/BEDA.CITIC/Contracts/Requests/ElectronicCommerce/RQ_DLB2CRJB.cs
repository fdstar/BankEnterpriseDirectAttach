using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// B2C商户退款经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLB2CRJB : RqBase<RS_DLB2CRJB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLB2CRJB"; set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<B2CMerchantRefund> Collection { get; set; }

        
    }
    /// <summary>
    /// B2C商户退款经办
    /// </summary>
    public class B2CMerchantRefund
    {
        /// <summary>
        /// B2C退款流水号varchar(20)
        /// </summary>
        [XmlElement("refundFlwNo")]
        public string RefundFlwNo { get; set; }
        /// <summary>
        /// 原订单号 varchar(20)
        /// </summary>
        [XmlElement("orderNo")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 原订单日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// 原订单日期 char(8) 格式YYYYMMDD, 对应<see cref="OrderDate"/>
        /// </summary>
        [XmlElement("orderDate")]
        public string OrderDateStr
        {
            get
            {
                return this.OrderDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OrderDate = tmp;
                }
            }
        }
        /// <summary>
        /// 交易金额decimal(15,2) 
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 摘要 varchar(102)，可空
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
    }
}
