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
    /// 3.10.5跨行账户他行账户收款请求主体
    /// </summary>
    public class V1_CRSGATHERTRNRQ : IRequest<V1_CRSGATHERTRNRS>
    {
        /// <summary>
        /// 3.10.5跨行账户他行账户收款请求主体
        /// </summary>
        public CRSGATHERTRNRQ CRSGATHERTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.10.5跨行账户他行账户收款请求主体
    /// </summary>
    public class CRSGATHERTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.10.5跨行账户他行账户收款请求
        /// </summary>
        [XmlElement(Order = 1)]
        public CRSGATHERTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.10.5跨行账户他行账户收款请求内容
    /// </summary>
    public class CRSGATHERTRN_RQBODY
    {
        /// <summary>
        /// 付款账户信息	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public RQACCT ACCTFROM { get; set; }
        /// <summary>
        /// 收款账户信息	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public RQACCT ACCTTO { get; set; }
        /// <summary>
        /// 协议号，最长140 协议号可通过他行账户协议查询获取 必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string AGRM { get; set; }
        /// <summary>
        /// 付款金额，decimal(15,2) 即整数位最长13位，小数位2位 必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 用途，最长50位	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 业务种类编码 见附录《他行核心业务种类代码类型》	必输
        /// 00100  电费
        /// 00200  水暖费
        /// 00300  煤气费
        /// 00400  电话费
        /// 00500  通讯费
        /// 00600  保险费
        /// 00700  房屋管理费
        /// 00800  代理服务费
        /// 00900  学教费
        /// 01000  有线电视费
        /// 01100  企业管理费用
        /// 01200  薪金报酬
        /// 02025  贷款还款房贷类	
        /// 02026  贷款还款车贷类
        /// 02027  贷款还款信用卡类
        /// 09001  其他
        /// </summary>
        [XmlElement(Order = 5)]
        public string BUSINESSTYPE { get; set; }
    }
}
