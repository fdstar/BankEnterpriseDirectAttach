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
    /// 23.27.公司卡入金锁定状态查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_27 : CMBBase<RQINFO>, IRequest<RS23_27>
    {
        /// <summary>
        /// NTQRYLCK
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLCK";
        /// <summary>
        /// 23.27.公司卡入金锁定状态查询请求内容
        /// </summary>
        public NTQRYLCKX1 NTQRYLCKX1 { get; set; }
    }
    /// <summary>
    /// 23.27.公司卡入金锁定状态查询请求内容
    /// </summary>
    public class NTQRYLCKX1
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
        /// <summary>
        /// 中止类型	C(1)    A：中止所有业务
        /// </summary>
        public string LCKTYP { get; set; }
        /// <summary>
        /// 中止子项	C(2)    AC：保证金入金锁定
        /// </summary>
        public string LCKITM { get; set; }
    }
}
