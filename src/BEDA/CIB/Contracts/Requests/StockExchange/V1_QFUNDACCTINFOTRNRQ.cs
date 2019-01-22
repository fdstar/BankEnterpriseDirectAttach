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
    /// 3.5.8银期资金查询请求主体
    /// </summary>
    public class V1_QFUNDACCTINFOTRNRQ : IRequest<V1_QFUNDACCTINFOTRNRS>
    {
        /// <summary>
        /// 3.5.8银期资金查询请求主体
        /// </summary>
        public QFUNDACCTINFOTRNRQ QFUNDACCTINFOTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.5.8银期资金查询请求主体
    /// </summary>
    public class QFUNDACCTINFOTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.5.8银期资金查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public QFUNDACCTINFOTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.5.8银期资金查询请求内容
    /// </summary>
    public class QFUNDACCTINFOTRN_RQBODY
    {
        /// <summary>
        /// 查询账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 资金账号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string FUNDACCTNO { get; set; }
        /// <summary>
        /// 资金账户密码，最长6位	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string PWD { get; set; }
    }
}
