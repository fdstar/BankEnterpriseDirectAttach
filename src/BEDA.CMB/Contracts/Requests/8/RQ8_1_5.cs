using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 8.1.5.浏览基金信息NTFNDCOD请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_1_5 : CMBBase<RQINFO>, IRequest<RS8_1_5>
    {
        /// <summary>
        /// NTFNDCOD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNDCOD";
        /// <summary>
        /// 8.1.5.浏览基金信息NTFNDCOD请求内容
        /// </summary>
        public NTFNDCODY NTFNDCODY { get; set; }
    }
    /// <summary>
    /// 8.1.5.浏览基金信息NTFNDCOD请求内容
    /// </summary>
    public class NTFNDCODY
    {
        /// <summary>
        /// 基金分类	C(1)	S-股票型，B-债券型，M-货币型，1-混合型
        /// </summary>
        public string FNDCLS { get; set; }
    }
}
