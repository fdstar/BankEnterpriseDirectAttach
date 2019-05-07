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
    /// 27.15.多级现金池设置详情查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_15 : CMBBase<RQINFO>, IRequest<RS27_15>
    {
        /// <summary>
        /// NTMTLINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLINF";
        /// <summary>
        /// 27.15.多级现金池设置详情查询请求内容
        /// </summary>
        public NTMTLINFX1 NTMTLINFX1 { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询请求内容
    /// </summary>
    public class NTMTLINFX1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
