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
    /// 8.2.3.智能现金池定额定投计划列表查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_2_3 : CMBBase<RQINFO>, IRequest<RS8_2_3>
    {
        /// <summary>
        /// NTFNPPL1    
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPPL1";
        /// <summary>
        /// 8.2.3.智能现金池定额定投计划列表查询请求内容
        /// </summary>
        public NTFNPPLSY NTFNPPLSY { get; set; }
    }
    /// <summary>
    /// 8.2.3.智能现金池定额定投计划列表查询请求内容
    /// </summary>
    public class NTFNPPLSY
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
        /// 交易代码	C(4)	J022=智能投资 J024=智能赎回
        /// </summary>
        public string TRSCOD { get; set; }
    }
}
