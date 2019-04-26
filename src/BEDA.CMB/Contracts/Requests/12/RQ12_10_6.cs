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
    /// 12.10.6.离岸外汇汇款明细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_10_6 : CMBBase<RQINFO>, IRequest<RS12_10_6>
    {
        /// <summary>
        /// NTRTOINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRTOINF";
        /// <summary>
        /// 12.10.6.离岸外汇汇款明细查询请求内容
        /// </summary>
        public NTRTOINFX NTRTOINFX { get; set; }
    }
    /// <summary>
    /// 12.10.6.离岸外汇汇款明细查询请求内容
    /// </summary>
    public class NTRTOINFX
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 特殊码 50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
