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
    /// 商户退款经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLMFDSUB : RqBase<RS_DLMFDSUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLB2CRJB"; set { } }

        /// <summary>
        /// 总金额decimal(15,2)
        /// </summary>
        [XmlElement("trnAmt")]
        public decimal TrnAmt { get { return this.Collection?.List?.Sum(x=>x.CancelAmt) ?? 0; } set { } }
        /// <summary>
        /// 总笔数int(4)
        /// </summary>
        [XmlElement("trnSum")]
        public int TrnSum { get { return this.Collection?.List?.Count ?? 0; } set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<MerchantCancel> Collection { get; set; }

        
    }
    /// <summary>
    /// 商户退款经办
    /// </summary>
    public class MerchantCancel
    {
        /// <summary>
        /// 记录编号int(4)
        /// </summary>
        [XmlElement("Id")]
        public int Id { get; set; }
        /// <summary>
        /// 订单号 varchar(40)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 订单金额 decimal(15,2)
        /// </summary>
        [XmlElement("cancelAmt")]
        public decimal CancelAmt { get; set; }
        /// <summary>
        /// 摘要 varchar(102)，可空
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
    }
}
