using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 8.9.4.个股期权查询券商编号及保证金请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_9_4 : CMBBase<RQINFO>, IRequest<RS8_9_4>
    {
        /// <summary>
        /// NTCNVQSG
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCNVQSG";
        /// <summary>
        /// 8.9.4.个股期权查询券商编号及保证金请求内容
        /// </summary>
        public NTSECCNVX NTSECCNVX { get; set; }
    }
}
