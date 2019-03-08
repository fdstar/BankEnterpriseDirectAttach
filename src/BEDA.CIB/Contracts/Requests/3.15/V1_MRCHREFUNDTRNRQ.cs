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
    /// 3.15.1电子商务商户单笔退款请求主体
    /// </summary>
    public class V1_MRCHREFUNDTRNRQ : IRequest<V1_MRCHREFUNDTRNRS>
    {
        /// <summary>
        /// 3.15.1电子商务商户单笔退款请求主体
        /// </summary>
        public MRCHREFUNDTRNRQ MRCHREFUNDTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.15.1电子商务商户单笔退款请求主体
    /// </summary>
    public class MRCHREFUNDTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.15.1电子商务商户单笔退款请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public MRCHREFUNDTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.15.1电子商务商户单笔退款请求内容
    /// </summary>
    public class MRCHREFUNDTRN_RQBODY
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
        /// 订单金额，decimal(15,2)，即整数位最长13位，小数位2位	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal ORDERAMT { get; set; }
        /// <summary>
        /// 退款金额，decimal(15,2)，即整数位最长13位，小数位2位	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal REFUNDAMT { get; set; }
        /// <summary>
        /// 期望转帐日期，格式：yyyy-MM-dd  非必输
        /// 若节点不输为空，则默认三日内审批通过即付
        /// </summary>
        [XmlIgnore]
        public DateTime? DTDUE { get; set; }
        /// <summary>
        /// 期望转帐日期，格式：YYYY-MM-DD, 对应<see cref="DTDUE"/>	非必输 
        /// 若节点不输为空，则默认三日内审批通过即付
        /// </summary>
        [XmlElement("DTDUE", Order = 5)]
        public string DTDUEStr
        {
            get
            {
                return this.DTDUE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DTDUE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 备注，最长50位
        /// </summary>
        [XmlElement(Order = 6)]
        public string MEMO { get; set; }
    }
}
