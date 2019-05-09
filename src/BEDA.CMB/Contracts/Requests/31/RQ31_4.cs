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
    /// 31.4.内部户MT940业务详情查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ31_4 : CMBBase<RQINFO>, IRequest<RS31_4>
    {
        /// <summary>
        /// NTIAMIFD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIAMIFD";
        /// <summary>
        /// 31.4.内部户MT940业务详情查询请求内容
        /// </summary>
        public NTIAMIFDY1 NTIAMIFDY1 { get; set; }
    }
    /// <summary>
    /// 31.4.内部户MT940业务详情查询请求内容
    /// </summary>
    public class NTIAMIFDY1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
