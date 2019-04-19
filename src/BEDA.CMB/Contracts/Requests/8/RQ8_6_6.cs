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
    /// 8.6.6.组合存款协议列表查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_6_6 : CMBBase<RQINFO>, IRequest<RS8_6_6>
    {
        /// <summary>
        /// NTCMAQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAQRY";
        /// <summary>
        /// 8.6.6.组合存款协议列表查询请求内容
        /// </summary>
        public NTCMAQRYX1 NTCMAQRYX1 { get; set; }
    }
    /// <summary>
    /// 8.6.6.组合存款协议列表查询请求内容
    /// </summary>
    public class NTCMAQRYX1
    {
        /// <summary>
        /// 业务模式编号	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
    }
}
