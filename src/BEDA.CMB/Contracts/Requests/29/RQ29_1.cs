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
    /// 29.1.商户清分列表查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ29_1 : CMBBase<RQINFO>, IRequest<RS29_1>
    {
        /// <summary>
        /// NTSTMQRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSTMQRT";
        /// <summary>
        /// 29.1.商户清分列表查询请求内容
        /// </summary>
        public NTSTMQRTY1 NTSTMQRTY1 { get; set; }
    }
    /// <summary>
    /// 29.1.商户清分列表查询请求内容
    /// </summary>
    public class NTSTMQRTY1
    {
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string MODNBR { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 行内商户号	C(20)
        /// </summary>
        public string MCHSID { get; set; }
    }
}
