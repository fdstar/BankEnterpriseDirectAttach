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
    /// 8.6.7.组合存款协议明细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_6_7 : CMBBase<RQINFO>, IRequest<RS8_6_7>
    {
        /// <summary>
        /// NTCMAINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAINF";
        /// <summary>
        /// 8.6.7.组合存款协议明细查询请求内容
        /// </summary>
        public NTCMAINFX1 NTCMAINFX1 { get; set; }
    }
    /// <summary>
    /// 8.6.7.组合存款协议明细查询请求内容
    /// </summary>
    public class NTCMAINFX1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
    }
}
