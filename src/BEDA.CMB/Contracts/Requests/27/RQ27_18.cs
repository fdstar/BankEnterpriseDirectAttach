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
    /// 27.18.划拨详情查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_18 : CMBBase<RQINFO>, IRequest<RS27_18>
    {
        /// <summary>
        /// NTHTXINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTHTXINF";
        /// <summary>
        /// 27.18.划拨详情查询请求内容
        /// </summary>
        public NTHTXINFX1 NTHTXINFX1 { get; set; }
    }
    /// <summary>
    /// 27.18.划拨详情查询请求内容
    /// </summary>
    public class NTHTXINFX1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
