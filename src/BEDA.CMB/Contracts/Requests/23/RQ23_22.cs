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
    /// 23.22.公司卡解除中止业务（解锁）请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_22 : CMBBase<RQINFO>, IRequest<RS23_22>
    {
        /// <summary>
        /// NTLCKRLS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLCKRLS";
        /// <summary>
        /// 23.22.公司卡解除中止业务（解锁）请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 23.22.公司卡解除中止业务（解锁）请求内容
        /// </summary>
        public NTLCKRLSX1 NTLCKRLSX1 { get; set; }
    }
    /// <summary>
    /// 23.22.公司卡解除中止业务（解锁）请求内容
    /// </summary>
    public class NTLCKRLSX1
    {
        /// <summary>
        /// 分行号   	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 公司卡卡号	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 公司结算户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 中止类型	C(1)    A：中止所有业务
        /// </summary>
        public string RLSTYP { get; set; }
        /// <summary>
        /// 中止子项       	C(2)    AC：保证金入金锁定
        /// </summary>
        public string RLSITM { get; set; }
        /// <summary>
        /// 中止子项维护类型	C(2)    CB: 保证金入金锁定解除中止所有业务
        /// </summary>
        public string RLSMNT { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
