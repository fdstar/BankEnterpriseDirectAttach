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
    /// 6.11.订单单笔查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_11 : CMBBase<RQINFO>, IRequest<RS6_11>
    {
        /// <summary>
        /// NTQRYORY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYORY";
        /// <summary>
        /// 6.11.订单单笔查询请求内容
        /// </summary>
        public NTQRYORYX1 NTQRYORYX1 { get; set; }
    }
    /// <summary>
    /// 6.11.订单单笔查询请求内容
    /// </summary>
    public class NTQRYORYX1
    {
        /// <summary>
        /// 业务参考号	C(30)   不支持模糊查询
        /// </summary>
        public string YURREF { get; set; }
    }
}
