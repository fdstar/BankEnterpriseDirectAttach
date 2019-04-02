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
    /// 14.5.大额划拨交易明细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ14_5 : CMBBase<RQINFO>, IRequest<RS14_5>
    {
        /// <summary>
        /// SDKNTFMTINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTFMTINF";
        /// <summary>
        /// 14.5.大额划拨交易明细查询请求内容
        /// </summary>
        public NTGMTINFX NTGMTINFX { get; set; }
    }
    /// <summary>
    /// 14.5.大额划拨交易明细查询请求内容
    /// </summary>
    public class NTGMTINFX
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 交易类型	C(3)	PTS:母公司划拨给子公司;STP:子公司划拨给母公司
        /// </summary>
        public string TRSCOD { get; set; }
    }
}
