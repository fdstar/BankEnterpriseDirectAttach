using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 集团账户成员交易明细查询请求主体
    /// </summary>
    public class SECURITIES_MSGSRQV1_CMSTMTQUERYTRNRQ : IRequest<SECURITIES_MSGSV1_CMINNERQUERYTRNRS>
    {
        /// <summary>
        /// 集团账户成员交易明细查询
        /// </summary>
        public CMSTMTQUERYTRNRQ CMSTMTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 集团账户成员交易明细查询
    /// </summary>
    public class CMSTMTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 集团账户成员交易明细查询内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CMSTMTQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 集团账户成员交易明细查询内容
    /// </summary>
    public class CMSTMTQUERYTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 结算中心账户信息，必输
        /// </summary>
        [XmlElement(Order = 0)]
        public RQBODY FUNDACCT { get; set; }
        /// <summary>
        /// 成员单位账户信息，必输
        /// 查询结算中心明细时，此处输入结算中心帐号
        /// </summary>
        [XmlElement(Order = 1)]
        public RQBODY MBRACCT { get; set; }
        /// <summary>
        /// 起始日期YYYY-MM-DD	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string DTSTART { get; set; }
        /// <summary>
        /// 截止日期YYYY-MM-DD	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string DTEND { get; set; }
        /// <summary>
        /// 最小金额，decimal(15,2)，即整数最长13位，小数2位	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 最大金额，decimal(15,2)，即整数最长13位，小数2位	非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? MAXAMT { get; set; }
    }
}
