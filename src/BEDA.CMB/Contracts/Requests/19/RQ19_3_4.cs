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
    /// 19.3.4.电子商票贴现经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_3_4 : CMBBase<RQINFO>, IRequest<RS19_3_4>
    {
        /// <summary>
        /// SDKCHMHOR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKCHMHOR";
        /// <summary>
        /// 19.3.4.电子商票贴现经办请求内容
        /// </summary>
        public NTCHMHORX NTCHMHORX { get; set; }
        /// <summary>
        /// 19.3.4.电子商票贴现经办请求集合
        /// </summary>
        [XmlElement("NTTKTINFX")]
        public List<NTTKTINFX> List { get; set; }
    }
    /// <summary>
    /// 19.3.4.电子商票贴现经办请求内容
    /// </summary>
    public class NTCHMHORX
    {
        /// <summary>
        /// 业务模式编号	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务模式名称	Z(200)  业务模式编号、业务模式名称不能同时为空。
        /// </summary>
        public string MODALS { get; set; }
        /// <summary>
        /// 交易行机构号	C(6)
        /// </summary>
        public string TRSBNO { get; set; }
        /// <summary>
        /// 交易行名称	Z(62)
        /// </summary>
        public string BNONAM { get; set; }
        /// <summary>
        /// 收方分行号	C(2)    收方账号为招行账号时必输
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收方帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方户名	Z(62)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方行名称	Z(62)
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 收方行地址	Z(62)
        /// </summary>
        public string CRTADR { get; set; }
        /// <summary>
        /// 贴现方式	C(1)	A：正常贴现 B：买方付息贴现
        /// </summary>
        public string CSHAPP { get; set; }
        /// <summary>
        /// 帐号系统内外标志	C(1)    收方账号为招行账号填Y，否者填N
        /// </summary>
        public string ACTFLG { get; set; }
        /// <summary>
        /// 业务参考号	C(30)   必须唯一
        /// </summary>
        public string YURREF { get; set; }
    }
}
