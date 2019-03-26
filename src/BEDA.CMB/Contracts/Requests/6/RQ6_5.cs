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
    /// 6.5.订单确认请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_5 : CMBBase<RQINFO>, IRequest<RS6_5>
    {
        /// <summary>
        /// NTORDCFM
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTORDCFM";
        /// <summary>
        /// 6.5.订单确认请求集合
        /// </summary>
        [XmlElement("NTORDCFMX")]
        public List<NTORDCFMX> List { get; set; }
    }
    /// <summary>
    /// 6.5.订单确认请求内容
    /// </summary>
    public class NTORDCFMX
    {
        /// <summary>
        /// 商户号	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 银行订单号   	C (10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 银行订单支付号	C (10)
        /// </summary>
        public string SUBSEQ { get; set; }
        /// <summary>
        /// 确认状态	C(1)	A = 确认 C = 撤销
        /// </summary>
        public string STSCOD { get; set; }
    }
}
