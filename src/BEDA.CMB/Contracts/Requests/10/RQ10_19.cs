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
    /// 10.19.查询基准利率请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_19 : CMBBase<RQINFO>, IRequest<RS10_19>
    {
        /// <summary>
        /// NTLIRBRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLIRBRT";
        /// <summary>
        /// 10.19.查询基准利率请求内容
        /// </summary>
        public NTLIRBRTX NTLIRBRTX { get; set; }
    }
    /// <summary>
    /// 10.19.查询基准利率请求内容
    /// </summary>
    public class NTLIRBRTX
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
