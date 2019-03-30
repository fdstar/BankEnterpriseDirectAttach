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
    /// 10.18.大额资金划拨请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_18 : CMBBase<RQINFO>, IRequest<RS10_18>
    {
        /// <summary>
        /// NTLLMBRP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLLMBRP";
        /// <summary>
        /// 10.18.大额资金划拨请求内容
        /// </summary>
        public NTLLMBRPX NTLLMBRPX { get; set; }
    }
    /// <summary>
    /// 10.18.大额资金划拨请求内容
    /// </summary>
    public class NTLLMBRPX
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
        /// 划拨方向	C(3)	A.32划拨方向
        /// </summary>
        public string BRPDRT { get; set; }
        /// <summary>
        /// 划拨金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
