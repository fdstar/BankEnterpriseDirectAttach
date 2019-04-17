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
    /// 23.26.公司卡可入账状态查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_26 : CMBBase<RQINFO>, IRequest<RS23_26>
    {
        /// <summary>
        /// NTQRYEAT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYEAT";
        /// <summary>
        /// 23.26.公司卡可入账状态查询请求内容
        /// </summary>
        public NTQRYEATX1 NTQRYEATX1 { get; set; }
    }
    /// <summary>
    /// 23.26.公司卡可入账状态查询请求内容
    /// </summary>
    public class NTQRYEATX1
    {
        /// <summary>
        /// 分行号     	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 公司卡卡号	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 公司结算户 	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
    }
}
