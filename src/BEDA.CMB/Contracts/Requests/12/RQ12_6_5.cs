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
    /// 12.6.5.支付机构查询结售汇申请项下子业务明细请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_6_5 : CMBBase<RQINFO>, IRequest<RS12_6_5>
    {
        /// <summary>
        /// NTJSBQRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJSBQRT";
        /// <summary>
        /// 12.6.5.支付机构查询结售汇申请项下子业务明细请求内容
        /// </summary>
        public NTJSBQRTX NTJSBQRTX { get; set; }
    }
    /// <summary>
    /// 12.6.5.支付机构查询结售汇申请项下子业务明细请求内容
    /// </summary>
    public class NTJSBQRTX
    {
        /// <summary>
        /// 申请类型	C(4)    EXSL：结汇 EXBY：购汇
        /// </summary>
        public string JSHCOD { get; set; }
        /// <summary>
        /// 批次号 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 母业务网上业务编号	C(30)
        /// </summary>
        public string APPCNO { get; set; }
        /// <summary>
        /// 轮次序号	N(6)
        /// </summary>
        public int LODSEQ { get; set; }
    }
}
