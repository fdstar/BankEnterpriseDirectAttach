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
    /// 8.2.4.基金留存定投计划列表查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_2_4 : CMBBase<RQINFO>, IRequest<RS8_2_4>
    {
        /// <summary>
        /// NTFNPPL2    
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPPL2";
        /// <summary>
        /// 8.2.4.基金留存定投计划列表查询请求内容
        /// </summary>
        public NTFNPPLSY NTFNPPLSY { get; set; }
    }
}
