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
    /// 10.17.查询协议信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_17 : CMBBase<RQINFO>, IRequest<RS10_17>
    {
        /// <summary>
        /// SDKNTCRSPSL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCRSPSL";
        /// <summary>
        /// 10.17.查询协议信息请求内容
        /// </summary>
        public NTCRSPSLY NTCRSPSLY { get; set; }
    }
    /// <summary>
    /// 10.17.查询协议信息请求内容
    /// </summary>
    public class NTCRSPSLY
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	N(5)
        /// </summary>
        public string CRPSEQ { get; set; }
    }
}
