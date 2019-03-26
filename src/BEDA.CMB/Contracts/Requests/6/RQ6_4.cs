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
    /// 6.4.商户确认查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_4 : CMBBase<RQINFO>, IRequest<RS6_4>
    {
        /// <summary>
        /// NTMIQWOD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMIQWOD";
        /// <summary>
        /// 6.4.商户确认查询请求内容  默认已实例化
        /// </summary>
        public NTMIQWODX NTMIQWODX { get; set; } = new NTMIQWODX();
    }
    /// <summary>
    /// 6.4.商户确认查询请求内容
    /// </summary>
    public class NTMIQWODX
    {
    }
}
