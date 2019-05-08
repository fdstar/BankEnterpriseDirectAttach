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
    /// 28.1.5.详情查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_1_5 : CMBBase<RQINFO>, IRequest<RS28_1_5>
    {
        /// <summary>
        /// NTDUMINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDUMINF";
        /// <summary>
        /// 28.1.5.详情查询请求内容
        /// </summary>
        public NTDUMINFX1 NTDUMINFX1 { get; set; }
    }
    /// <summary>
    /// 28.1.5.详情查询请求内容
    /// </summary>
    public class NTDUMINFX1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
