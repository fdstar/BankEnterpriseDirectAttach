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
    /// B2C商户退款经办响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLB2CRJB : RsBase
    {
        /// <summary>
        /// 批次号 varchar(8)
        /// </summary>
        [XmlElement("batNo")]
        public string BatNo { get; set; }
        /// <summary>
        /// 银行受理成功总笔数 int
        /// </summary>
        [XmlElement("sucTotalNum")]
        public int SucTotalNum { get; set; }
        /// <summary>
        /// 银行受理成功总金额 decimal(15,2)
        /// </summary>
        [XmlElement("sucTotalAmt")]
        public decimal SucTotalAmt { get; set; }
        /// <summary>
        /// 银行受理失败总笔数int
        /// </summary>
        [XmlElement("errTotalNum")]
        public int ErrTotalNum { get; set; }
        /// <summary>
        /// 银行受理失败总金额 decimal(15,2)
        /// </summary>
        [XmlElement("errTotalAmt")]
        public decimal ErrTotalAmt { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<B2CMerchantRefundResult> List { get; set; }
    }
    /// <summary>
    /// B2C商户退款经办结果
    /// </summary>
    public class B2CMerchantRefundResult
    {
        /// <summary>
        /// B2C退款流水号 varchar(20)
        /// </summary>
        [XmlElement("refundFlwNo")]
        public string RefundFlwNo { get; set; }
        /// <summary>
        /// 交易银行受理状态char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 交易银行受理状态信息 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
    }
}
