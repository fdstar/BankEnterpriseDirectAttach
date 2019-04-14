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
    /// 19.2.12.提前兑付经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_12 : CMBBase<RQINFO>, IRequest<RS19_2_12>
    {
        /// <summary>
        /// SDKASHOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKASHOPR";
        /// <summary>
        /// 19.2.12.提前兑付经办请求内容
        /// </summary>
        public NTASHOPRX NTASHOPRX { get; set; }
        /// <summary>
        /// 19.2.12.提前兑付经办请求集合
        /// </summary>
        [XmlElement("NTASHINFX")]
        public List<NTASHINFX> List { get; set; }
    }
    /// <summary>
    /// 19.2.12.提前兑付经办请求内容
    /// </summary>
    public class NTASHOPRX
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
        /// 交易账号	C(35)
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)   必须唯一
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 19.2.12.提前兑付经办请求内容
    /// </summary>
    public class NTASHINFX
    {
        /// <summary>
        /// 票据流水号	C(10)   提前兑付经办票据信息查询
        /// </summary>
        public string SEQNBR { get; set; }
    }
}
