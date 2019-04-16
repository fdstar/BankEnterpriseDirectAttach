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
    /// 23.2.取公司结算户下面所有公司卡信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_2 : CMBBase<RQINFO>, IRequest<RS23_2>
    {
        /// <summary>
        /// NTCPRLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRLST";
        /// <summary>
        /// 23.2.取公司结算户下面所有公司卡信息请求内容
        /// </summary>
        public NTCPRLSTX NTCPRLSTX { get; set; }
    }
    /// <summary>
    /// 23.2.取公司结算户下面所有公司卡信息请求内容
    /// </summary>
    public class NTCPRLSTX
    {
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
