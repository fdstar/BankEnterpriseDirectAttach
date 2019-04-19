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
    /// 8.6.2.关联智能定期存款经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_6_2 : CMBBase<RQINFO>, IRequest<RS8_6_2>
    {
        /// <summary>
        /// NTCMARLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMARLT";
        /// <summary>
        /// 8.6.2.关联智能定期存款经办请求内容
        /// </summary>
        public NTCMARLTX1 NTCMARLTX1 { get; set; }
    }
    /// <summary>
    /// 8.6.2.关联智能定期存款经办请求内容
    /// </summary>
    public class NTCMARLTX1
    {
        /// <summary>
        /// 业务模式编号	C(5)    不能同时为空，必须填一个。（如果两者都不为空以BUSMOD为准）
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务模式名称	Z(62)
        /// </summary>
        public string MODALS { get; set; }
        /// <summary>
        /// 定期分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期帐号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 活期分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
