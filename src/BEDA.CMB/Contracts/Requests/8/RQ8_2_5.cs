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
    /// 8.2.5.定投计划详细信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_2_5 : CMBBase<RQINFO>, IRequest<RS8_2_5>
    {
        /// <summary>
        /// NTFNPPDT    
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPPDT";
        /// <summary>
        /// 8.2.5.定投计划详细信息请求内容
        /// </summary>
        public NTFNPPDTX NTFNPPDTX { get; set; }
    }
    /// <summary>
    /// 8.2.5.定投计划详细信息请求内容
    /// </summary>
    public class NTFNPPDTX
    {
        /// <summary>
        /// 投资计划编号	C(24)
        /// </summary>
        public string TAAAPP { get; set; }
    }
}
