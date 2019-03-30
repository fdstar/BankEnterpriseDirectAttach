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
    /// 10.20.查询子公司点差利率请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_20 : CMBBase<RQINFO>, IRequest<RS10_20>
    {
        /// <summary>
        /// NTLIRFRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLIRFRT";
        /// <summary>
        /// 10.20.查询子公司点差利率请求内容
        /// </summary>
        public NTLIRFRTX NTLIRFRTX { get; set; }
    }
    /// <summary>
    /// 10.20.查询子公司点差利率请求内容
    /// </summary>
    public class NTLIRFRTX
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	N(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
