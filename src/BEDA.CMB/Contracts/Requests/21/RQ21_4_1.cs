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
    /// 21.4.1.网银借记请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ21_4_1 : CMBBase<RQINFO>, IRequest<RS21_4_1>
    {
        /// <summary>
        /// NTIBDOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIBDOPR";
        /// <summary>
        /// 21.4.1.网银借记请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 21.4.1.网银借记请求集合
        /// </summary>
        [XmlElement("NTIBDOPRX")]
        public List<NTIBDOPRX> List { get; set; }
    }
    /// <summary>
    /// 21.4.1.网银借记请求内容
    /// </summary>
    public class NTIBDOPRX
    {
        /// <summary>
        /// 流水号	C(10)
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 帐号银行号 	C(2)    必输为CB,即我行账号
        /// </summary>
        public string BBKNBR { get; set; } = "CB";
        /// <summary>
        /// 帐号       	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 内部协议号 	C(10)   账号所签署已生效的借记协议对应的我行内部协议号
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 参考号     	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 币种	C(2)	附录 A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 业务类型编码	C(4)	附录A.49
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 业务种类编码	C(5)
        /// </summary>
        public string TRSCAT { get; set; }
        /// <summary>
        /// 附言	Z(235)
        /// </summary>
        public string RMKTXT { get; set; }
        /// <summary>
        /// 附件标志 	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
    }
}
