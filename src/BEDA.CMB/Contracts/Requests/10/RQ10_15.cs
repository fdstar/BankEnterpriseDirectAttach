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
    /// 10.15.资金汇总查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_15 : CMBBase<RQINFO>, IRequest<RS10_15>
    {
        /// <summary>
        /// NTCFNTOT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCFNTOT";
        /// <summary>
        /// 10.15.资金汇总查询请求内容
        /// </summary>
        public NTCFNTOTX NTCFNTOTX { get; set; }
    }
    /// <summary>
    /// 10.15.资金汇总查询请求内容
    /// </summary>
    public class NTCFNTOTX
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	N(5)    ‘*‘表示全部子公司
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
