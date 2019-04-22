using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 12.2.6.支付机构查询实时汇率请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_2_6 : CMBBase<RQINFO>, IRequest<RS12_2_6>
    {
        /// <summary>
        /// NTEXRQAB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXRQAB";
        /// <summary>
        /// 12.2.6.支付机构查询实时汇率请求内容
        /// </summary>
        public NTRATEXRX NTRATEXRX { get; set; }
    }
    /// <summary>
    /// 12.2.6.支付机构查询实时汇率请求内容
    /// </summary>
    public class NTRATEXRX
    {
        /// <summary>
        /// 客户号 	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 账号   	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 卖出货币	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 特殊码 	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
