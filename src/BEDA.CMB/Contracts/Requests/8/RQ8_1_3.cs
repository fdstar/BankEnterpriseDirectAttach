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
    /// 8.1.3.基金账户查询NTFNDACT请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_1_3 : CMBBase<RQINFO>, IRequest<RS8_1_3>
    {
        /// <summary>
        /// NTFNDACT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNDACT";
        /// <summary>
        /// 8.1.3.基金账户查询NTFNDACT请求内容
        /// </summary>
        public NTFNDACTY NTFNDACTY { get; set; }
    }
    /// <summary>
    /// 8.1.3.基金账户查询NTFNDACT请求内容
    /// </summary>
    public class NTFNDACTY
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
    }
}
