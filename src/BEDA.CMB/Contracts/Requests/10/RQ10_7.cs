using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 10.7.查询指定母公司和子公司协议产品信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_7 : CMBBase<RQINFO>, IRequest<RS10_7>
    {
        /// <summary>
        /// SDKNTCRSPSR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCRSPSR";
        /// <summary>
        /// 10.7.查询指定母公司和子公司协议产品信息请求内容
        /// </summary>
        public NTCRSPSRY NTCRSPSRY { get; set; }
    }
    /// <summary>
    /// 10.7.查询指定母公司和子公司协议产品信息请求内容
    /// </summary>
    public class NTCRSPSRY
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
