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
    /// 21.1.4.取企业银行处理结果请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ21_1_4 : CMBBase<RQINFO>, IRequest<RS21_1_4>
    {
        /// <summary>
        /// NTRTVSTS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRTVSTS";
        /// <summary>
        /// 21.1.4.取企业银行处理结果请求内容
        /// </summary>
        public NTRTVSTSX NTRTVSTSX { get; set; }
    }
    /// <summary>
    /// 21.1.4.取企业银行处理结果请求内容
    /// </summary>
    public class NTRTVSTSX
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
