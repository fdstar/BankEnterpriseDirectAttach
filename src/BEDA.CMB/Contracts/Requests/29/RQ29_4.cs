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
    /// 29.4.商户清分处理结果查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ29_4 : CMBBase<RQINFO>, IRequest<RS29_4>
    {
        /// <summary>
        /// NTSTMQTS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSTMQTS";
        /// <summary>
        /// 29.4.商户清分处理结果查询请求内容
        /// </summary>
        public NTSTMQTSY1 NTSTMQTSY1 { get; set; }
    }
    /// <summary>
    /// 29.4.商户清分处理结果查询请求内容
    /// </summary>
    public class NTSTMQTSY1
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
