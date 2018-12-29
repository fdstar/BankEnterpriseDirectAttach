using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 集团支付请求主体
    /// </summary>
    public class SECURITIES_MSGSRQV1_XPMTTRNRQ : IRequest<SECURITIES_MSGSRSV1_XPMTTRNRS>
    {
        /// <summary>
        /// 集团支付
        /// </summary>
        public XPMTTRNRQ XPMTTRNRQ { get; set; }
    }
    /// <summary>
    /// 集团支付
    /// </summary>
    public class XPMTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 请求支付信息节点,如果不输则为查询客户端交易流水（TRNUID）的交易情况
        /// </summary>
        [XmlElement("XMPTRQ", Order = 1)]
        public XMPTRQ<XPMTTRN_FUNDACCT> XMPTRQ { get; set; }
    }
    /// <summary>
    /// 集团中心账户信息 集团中心账户(兴业银行账户)，18位
    /// </summary>
    public class XPMTTRN_FUNDACCT : RQBODY
    {
        /// <summary>
        /// 转账类型，1位
        /// 填0或空，表示结算中心与成员单位上拨下拨
        /// 填1表示结算中心与成员单位之间互转   非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public int? XPMTTYPE { get; set; }
    }
}
