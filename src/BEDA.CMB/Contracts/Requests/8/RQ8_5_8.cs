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
    /// 8.5.8.智能定期存款协议查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    [Obsolete("接口文档错误，响应部分参数需补全")]
    public class RQ8_5_8 : CMBBase<RQINFO>, IRequest<RS8_5_8>
    {
        /// <summary>
        /// NTTCAQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTTCAQRY";
        /// <summary>
        /// 8.5.8.智能定期存款协议查询请求内容
        /// </summary>
        public NTTCAQRYX1 NTTCAQRYX1 { get; set; }
    }
    /// <summary>
    /// 8.5.8.智能定期存款协议查询请求内容
    /// </summary>
    public class NTTCAQRYX1
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
