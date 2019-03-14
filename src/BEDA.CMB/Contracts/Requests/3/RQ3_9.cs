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
    /// 3.9.批量查询支付信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ3_9 : CMBBase<RQINFO>, IRequest<RS3_9>
    {
        /// <summary>
        /// NTSTLINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSTLINF";
        /// <summary>
        /// 3.9.批量查询支付信息请求内容
        /// </summary>
        [XmlElement("NTSTLINFX")]
        public List<NTSTLINFX> List { get; set; }
    }
    /// <summary>
    /// 3.9.批量查询支付信息请求内容
    /// </summary>
    public class NTSTLINFX
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
