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
    /// 18.6.境外账户维护明细请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ18_6 : CMBBase<RQINFO>, IRequest<RS18_6>
    {
        /// <summary>
        /// NTCACDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCACDTL";
        /// <summary>
        /// 18.6.境外账户维护明细请求内容
        /// </summary>
        public NTCACDTLX NTCACDTLX { get; set; }
    }
    /// <summary>
    /// 18.6.境外账户维护明细请求内容
    /// </summary>
    public class NTCACDTLX
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
