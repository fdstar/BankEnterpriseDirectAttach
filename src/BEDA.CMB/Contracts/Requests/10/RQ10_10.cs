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
    /// 10.10.点差维护请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_10 : CMBBase<RQINFO>, IRequest<RS10_10>
    {
        /// <summary>
        /// NTLIRFMN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLIRFMN";
        /// <summary>
        /// 10.10.点差维护请求内容
        /// </summary>
        public NTLIRFMNX NTLIRFMNX { get; set; }
    }
    /// <summary>
    /// 10.10.点差维护请求内容
    /// </summary>
    public class NTLIRFMNX
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
        /// 利率方向	C(3)	A.28 利率方向
        /// </summary>
        public string INRDRT { get; set; }
        /// <summary>
        /// 点差利率	I   	非负数
        /// </summary>
        public decimal INRVAL { get; set; }
        /// <summary>
        /// 负值标志	C(1)	Y或其他    Y-表示现在设的利率是负数；空或其他值都表示正数
        /// </summary>
        public string ABSFLG { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
