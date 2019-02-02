using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.19.10跨境资金池成员单位子账号交易明细查询响应主体
    /// </summary>
    public class V1_CBCPMEMTRADEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.19.10跨境资金池成员单位子账号交易明细查询响应主体
        /// </summary>
        public CBCPMEMTRADEQUERYTRNRS CBCPMEMTRADEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.10跨境资金池成员单位子账号交易明细查询响应主体
    /// </summary>
    public class CBCPMEMTRADEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.10跨境资金池成员单位子账号交易明细查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPMEMTRADEQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.10跨境资金池成员单位子账号交易明细查询响应内容
    /// </summary>
    public class CBCPMEMTRADEQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.19.10跨境资金池成员单位子账号交易明细查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<CBCPTRADEDETAILQUERYTRN_CONTENT> List { get; set; }
    }
}
