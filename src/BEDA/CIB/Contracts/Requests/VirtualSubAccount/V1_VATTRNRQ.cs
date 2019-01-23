using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.6.5虚拟子帐户对外支付请求主体
    /// </summary>
    public class V1_VATTRNRQ : IRequest<V1_VATTRNRS>
    {
        /// <summary>
        /// 3.6.5虚拟子帐户对外支付请求主体
        /// </summary>
        public VATTRNRQ VATTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.6.5虚拟子帐户对外支付请求主体
    /// </summary>
    public class VATTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.6.5虚拟子帐户对外支付请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public VATRQ VATRQ { get; set; }
    }
    /// <summary>
    /// 3.6.5虚拟子帐户对外支付请求内容
    /// </summary>
    public class VATRQ
    {
        /// <summary>
        /// 支付类型：1－虚拟子账户对外支付	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int VATTYPE { get; set; } = 1;
        /// <summary>
        /// 实体扣款账户，最大18位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 虚拟小序号, 最大6位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 对外支付信息	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public XFERINFO XFERINFO { get; set; }
    }
}
