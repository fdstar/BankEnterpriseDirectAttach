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
    /// 19.3.9.商票交易票据业务处理信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_3_9 : CMBBase<RQINFO>, IRequest<RS19_3_9>
    {
        /// <summary>
        /// SDKMHTLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMHTLST";
        /// <summary>
        /// 19.3.9.商票交易票据业务处理信息请求内容
        /// </summary>
        public NTCUSLSTX NTCUSLSTX { get; set; }
    }
}
