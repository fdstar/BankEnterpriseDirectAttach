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
    /// 8.4.6.业务明细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_6 : CMBBase<RQINFO>, IRequest<RS8_4_6>
    {
        /// <summary>
        /// NTFNCDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNCDTL";
        /// <summary>
        /// 8.4.6.业务明细查询请求内容
        /// </summary>
        public NTDTLFNCX NTDTLFNCX { get; set; }
    }
    /// <summary>
    /// 8.4.6.业务明细查询请求内容
    /// </summary>
    public class NTDTLFNCX
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
