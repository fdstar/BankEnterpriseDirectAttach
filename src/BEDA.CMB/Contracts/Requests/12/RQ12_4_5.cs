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
    /// 12.4.5.支付机构经办汇入汇款母业务请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_4_5 : CMBBase<RQINFO>, IRequest<RS12_4_5>
    {
        /// <summary>
        /// NTIRAJZP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIRAJZP";
        /// <summary>
        /// 12.4.5.支付机构经办汇入汇款母业务请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 12.4.5.支付机构经办汇入汇款母业务请求内容
        /// </summary>
        public NTIRAJZPX NTIRAJZPX { get; set; }
    }
    /// <summary>
    /// 12.4.5.支付机构经办汇入汇款母业务请求内容
    /// </summary>
    public class NTIRAJZPX
    {
        /// <summary>
        /// 业务参考号 	C(30)   参考号前三位按下面的个规则来填写，否则有可能会经办不通过 1、汇入时，IRT 2、汇出时，ORT
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 分行号     	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 客户号     	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 汇入汇款编号	C(16)
        /// </summary>
        public string IRMNBR { get; set; }
        /// <summary>
        /// 交易币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 集中支付机构标志	C(1)    1：支付机构跨境电商外汇集中收付 其他不是支付机构的业务
        /// </summary>
        public string SPLFLG { get; set; }
    }
}
