using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 8.2.2.基金份额查询（持仓基金查询）请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_2_2 : CMBBase<RQINFO>, IRequest<RS8_2_2>
    {
        /// <summary>
        /// NTFNPPOS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPPOS";
        /// <summary>
        /// 8.2.2.基金份额查询（持仓基金查询）请求内容
        /// </summary>
        public NTFNDPLSY NTFNDPLSY { get; set; }
    }
    /// <summary>
    /// 8.2.2.基金份额查询（持仓基金查询）请求内容
    /// </summary>
    public class NTFNDPLSY
    {
        /// <summary>
        /// 资金户口分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 资金户口     	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 基金协议	C(10)
        /// </summary>
        public string FNDCTR { get; set; }
        /// <summary>
        /// 基金代码	C(8)
        /// </summary>
        public string FNDCOD { get; set; }
    }
}
