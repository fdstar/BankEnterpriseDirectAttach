using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.15.2电子商务商户单笔订单查询请求主体
    /// </summary>
    public class V1_MRCHORDERTRNRQ : IRequest<V1_MRCHORDERTRNRS>
    {
        /// <summary>
        /// 3.15.2电子商务商户单笔订单查询请求主体
        /// </summary>
        public MRCHORDERTRNRQ MRCHORDERTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.15.2电子商务商户单笔订单查询请求主体
    /// </summary>
    public class MRCHORDERTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.15.2电子商务商户单笔订单查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public MRCHORDERTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.15.2电子商务商户单笔订单查询请求内容
    /// </summary>
    public class MRCHORDERTRN_RQBODY
    {
        /// <summary>
        /// 商户代号，6位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string MRCHNO { get; set; }
        /// <summary>
        /// 订单号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ORDERNO { get; set; }
        /// <summary>
        /// 订单查询类型：1－可支付、2－可退款、3－可撤单、0或空表示所有订单
        /// </summary>
        [XmlIgnore]
        public int? ORDERTYPE { get; set; }
        /// <summary>
        /// 订单查询类型：1－可支付、2－可退款、3－可撤单、0或空表示所有订单, 对应<see cref="ORDERTYPE"/>
        /// </summary>
        [XmlElement("ORDERTYPE", Order = 3)]
        public string ORDERTYPEStr
        {
            get
            {
                return this.ORDERTYPE?.ToString();
            }
            set
            {
                this.ORDERTYPE = value.TryConvert<int>();
            }
        }
    }
}
