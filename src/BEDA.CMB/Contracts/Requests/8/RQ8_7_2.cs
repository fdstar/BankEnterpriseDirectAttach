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
    /// 8.7.2.归集存款内部转账经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_7_2 : CMBBase<RQINFO>, IRequest<RS8_7_2>
    {
        /// <summary>
        /// NTCMCOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMCOPR";
        /// <summary>
        /// 8.7.2.归集存款内部转账经办请求内容
        /// </summary>
        public NTCMCOPRX1 NTCMCOPRX1 { get; set; }
    }
    /// <summary>
    /// 8.7.2.归集存款内部转账经办请求内容
    /// </summary>
    public class NTCMCOPRX1
    {
        /// <summary>
        /// 业务模式	C(5)    可通过前置机或者查询可经办的业务模式信息（ListMode）获得，业务代码为N36080
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2)	附录A.1
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
        /// <summary>
        /// 币种     	C(2)	附录A.3   	现只能人民币‘10’
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 转账金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
    }
}
