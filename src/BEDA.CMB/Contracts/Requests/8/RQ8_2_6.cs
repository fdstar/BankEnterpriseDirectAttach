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
    /// 8.2.6.智能现金池基金个性化查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_2_6 : CMBBase<RQINFO>, IRequest<RS8_2_6>
    {
        /// <summary>
        /// NTFNPATR    
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPATR";
        /// <summary>
        /// 8.2.6.智能现金池基金个性化查询请求内容
        /// </summary>
        public NTFNPATRX NTFNPATRX { get; set; }
    }
    /// <summary>
    /// 8.2.6.智能现金池基金个性化查询请求内容
    /// </summary>
    public class NTFNPATRX
    {
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
