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
    /// 23.3.取公司卡详细信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_3 : CMBBase<RQINFO>, IRequest<RS23_3>
    {
        /// <summary>
        /// NTCPRRTV
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRRTV";
        /// <summary>
        /// 23.3.取公司卡详细信息请求内容
        /// </summary>
        public NTCPRCD1X NTCPRCD1X { get; set; }
    }
    /// <summary>
    /// 23.3.取公司卡详细信息请求内容
    /// </summary>
    public class NTCPRCD1X
    {
        /// <summary>
        /// 公司卡号 	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 分行号   	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 公司结算户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
    }
}
