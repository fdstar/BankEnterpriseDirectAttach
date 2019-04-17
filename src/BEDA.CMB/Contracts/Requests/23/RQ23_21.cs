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
    /// 23.21 公司卡中止业务功能（锁卡）请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_21 : CMBBase<RQINFO>, IRequest<RS23_21>
    {
        /// <summary>
        /// NTLCKSET
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLCKSET";
        /// <summary>
        /// 23.21 公司卡中止业务功能（锁卡）请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 23.21 公司卡中止业务功能（锁卡）请求内容
        /// </summary>
        public NTLCKSETX1 NTLCKSETX1 { get; set; }
    }
    /// <summary>
    /// 23.21 公司卡中止业务功能（锁卡）请求内容
    /// </summary>
    public class NTLCKSETX1
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
        public string LCKTYP { get; set; }
        /// <summary>
        /// 中止子项       	C(2)    AC：保证金入金锁定
        /// </summary>
        public string LCKITM { get; set; }
        /// <summary>
        /// 中止子项维护类型	C(2)    CA: 保证金入金锁定中止所有业务
        /// </summary>
        public string LCKMNT { get; set; }
        /// <summary>
        /// 中止备注       	D(250)  备注或说明
        /// </summary>
        public string DESTXT { get; set; }
        /// <summary>
        /// 失效日期	C(3)    自动解除中止日期，未填则默认为0不自动解除
        /// </summary>
        public string EXPDAT { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
