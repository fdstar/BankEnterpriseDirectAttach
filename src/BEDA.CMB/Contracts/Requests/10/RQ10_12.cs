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
    /// 10.12.透支额度查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_12 : CMBBase<RQINFO>, IRequest<RS10_12>
    {
        /// <summary>
        /// NTLLMRTV
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLLMRTV";
        /// <summary>
        /// 10.12.透支额度查询请求内容
        /// </summary>
        public NTLLMRTVX NTLLMRTVX { get; set; }
    }
    /// <summary>
    /// 10.12.透支额度查询请求内容
    /// </summary>
    public class NTLLMRTVX
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
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
