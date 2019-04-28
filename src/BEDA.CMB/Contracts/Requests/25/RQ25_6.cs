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
    /// 25.6.还款功能业务明细请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ25_6 : CMBBase<RQINFO>, IRequest<RS25_6>
    {
        /// <summary>
        /// NTCDTINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCDTINF";
        /// <summary>
        /// 25.6.还款功能业务明细请求内容
        /// </summary>
        public NTCDTINFX1 NTCDTINFX1 { get; set; }
    }
    /// <summary>
    /// 25.6.还款功能业务明细请求内容
    /// </summary>
    public class NTCDTINFX1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
