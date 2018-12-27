using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 批量托收或子账户托收明细查询请求主体
    /// </summary>
    public class SECURITIES_MSGSRQV1_FBBATCHSTMTTRNRQ : IRequest<SECURITIES_MSGSRSV1_FBBATCHSTMTTRNRS>
    {
        /// <summary>
        /// 批量托收或子账户托收明细查询
        /// </summary>
        public FBBATCHSTMTTRNRQ FBBATCHSTMTTRNRQ { get; set; }
    }
    /// <summary>
    /// 批量托收或子账户托收明细查询
    /// </summary>
    public class FBBATCHSTMTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 批量托收或子账户托收明细查询内容
        /// </summary>
        [XmlElement(Order = 1)]
        public FBBATCHSTMTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 批量托收或子账户托收明细查询内容
    /// </summary>
    public class FBBATCHSTMTTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 生成批量托收指令时用的TRNUID 最长30位 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string CLIENTREF { get; set; }
        /// <summary>
        /// 操作账户代号，最长32位
        /// 子账户托收输入22位或24位子账户
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
    }
}
