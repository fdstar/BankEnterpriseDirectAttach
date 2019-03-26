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
    /// 6.3.生成签名请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_3 : CMBBase<RQINFO>, IRequest<RS6_3>
    {
        /// <summary>
        /// Signature
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "Signature";
        /// <summary>
        /// 6.3.生成签名请求内容
        /// </summary>
        public SDKEMPAYX SDKEMPAYX { get; set; }
    }
    /// <summary>
    /// 6.3.生成签名请求内容
    /// </summary>
    public class SDKEMPAYX
    {
        /// <summary>
        /// 订单信息	C(800)
        /// </summary>
        public string ORDINF { get; set; }
        /// <summary>
        /// 收方信息	C
        /// </summary>
        public string RCVINF { get; set; }
    }
}
