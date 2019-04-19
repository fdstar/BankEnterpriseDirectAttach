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
    /// 8.5.2.活期转智能定期经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_5_2 : CMBBase<RQINFO>, IRequest<RS8_5_2>
    {
        /// <summary>
        /// NTCTAOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCTAOPR";
        /// <summary>
        /// 8.5.2.活期转智能定期经办请求内容
        /// </summary>
        public NTCTAOPRX1 NTCTAOPRX1 { get; set; }
    }
    /// <summary>
    /// 8.5.2.活期转智能定期经办请求内容
    /// </summary>
    public class NTCTAOPRX1
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
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 币种	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 客户类别	C(1)    C-普通企业客户 O-离岸客户 F-同业客户
        /// </summary>
        public string CTLTYP { get; set; }
        /// <summary>
        /// 存期	C(6)	003000=三个月 006000=半年 012000=一年 024000=两年
        /// </summary>
        public string TERDUM { get; set; }
        /// <summary>
        /// 自动转存标志	C(1)    	1-不转存 2-本息转存 3-本金转存，利息转活期
        /// </summary>
        public string ATOFLG { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
