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
    /// 18.2.新增境外账户经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ18_2 : CMBBase<RQINFO>, IRequest<RS18_2>
    {
        /// <summary>
        /// NTOPRCAC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRCAC";
        /// <summary>
        /// 18.2.新增境外账户经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 18.2.新增境外账户经办请求集合
        /// </summary>
        [XmlElement("NTOPRCACX1")]
        public List<NTOPRCACX1> List { get; set; }
    }
    /// <summary>
    /// 18.2.新增境外账户经办请求内容
    /// </summary>
    public class NTOPRCACX1
    {
        /// <summary>
        /// 流水号	C(10)
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 分行号	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 行内账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 境外账号	C(35)
        /// </summary>
        public string CRSACC { get; set; }
        /// <summary>
        /// 境外账号名称	Z(100)
        /// </summary>
        public string CRSACN { get; set; }
        /// <summary>
        /// 币种	C(3)	A.47国际业务货币代码表
        /// </summary>
        public string CRSCCY { get; set; }
        /// <summary>
        /// 发报行名称	Z(100)
        /// </summary>
        public string CRSBNK { get; set; }
        /// <summary>
        /// 发报行SWIFT地址	Z(11)	
        /// </summary>
        public string SWFADR { get; set; }
        /// <summary>
        /// 保留字	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
