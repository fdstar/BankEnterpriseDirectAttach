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
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）请求主体
    /// </summary>
    public class V1_MAGENTPAYTRNRQ : IRequest<V1_MAGENTPAYTRNRS>
    {
        /// <summary>
        /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）请求主体
        /// </summary>
        public MAGENTPAYTRNRQ MAGENTPAYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）请求主体
    /// </summary>
    public class MAGENTPAYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MAGENTPAYRQ MAGENTPAYRQ { get; set; }
    }
    /// <summary>
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）请求内容
    /// </summary>
    public class MAGENTPAYRQ
    {
        /// <summary>
        /// 代付信息	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public MAGENTPAYINFO MAGENTPAYINFO { get; set; }
    }
    /// <summary>
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）代付信息
    /// </summary>
    public class MAGENTPAYINFO
    {
        /// <summary>
        /// 8位商户号，指商户、个人或外围系统在收付直通车系统开立的商户号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string MRCHNO { get; set; }
        /// <summary>
        /// 订单号，最大32位，必须唯一不可重复	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ORDERNO { get; set; }
        /// <summary>
        /// 二级商户名称，最大20位
        /// </summary>
        [XmlElement(Order = 3)]
        public string MRCHNAME { get; set; }
        /// <summary>
        /// 凭证代号，9位数字，可不填，默认使用电子凭证号	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 付款账户信息
        /// </summary>
        [XmlElement(Order =5)]
        public ACCT ACCTFROM { get; set; }
        /// <summary>
        /// 收款人账户信息
        /// </summary>
        [XmlElement(Order = 6)]
        public ACCTTO ACCTTO { get; set; }
        /// <summary>
        /// 交易金额，金额>0, 整数位最长15位，小数2位	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 用途，最大50位	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string PURPOSE { get; set; }
    }
}
