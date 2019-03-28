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
    /// 8.1.1.查询客户基金协议请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_1_1 : CMBBase<RQINFO>, IRequest<RS8_1_1>
    {
        /// <summary>
        /// NTFNDCTR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNDCTR";
        /// <summary>
        /// 8.1.1.查询客户基金协议请求内容
        /// </summary>
        public NTFNDCTRY NTFNDCTRY { get; set; }
    }
    /// <summary>
    /// 8.1.1.查询客户基金协议请求内容
    /// </summary>
    public class NTFNDCTRY
    {
        /// <summary>
        /// 资金户口分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 资金户口	C(35)
        /// </summary>
        public string EACNBR { get; set; }
    }
}
