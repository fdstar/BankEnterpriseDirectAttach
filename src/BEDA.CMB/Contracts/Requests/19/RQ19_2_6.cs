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
    /// 19.2.6.赎回经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_6 : CMBBase<RQINFO>, IRequest<RS19_2_6>
    {
        /// <summary>
        /// SDKBCKOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKBCKOPR";
        /// <summary>
        /// 19.2.6.赎回经办请求内容
        /// </summary>
        public NTBCKOPRX NTBCKOPRX { get; set; }
        /// <summary>
        /// 19.2.6.赎回经办请求集合
        /// </summary>
        [XmlElement("NTTKTINFX")]
        public List<NTTKTINFX> List { get; set; }
    }
    /// <summary>
    /// 19.2.6.赎回经办请求内容
    /// </summary>
    public class NTBCKOPRX
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
        /// 交易帐号	C(35)
        /// </summary>
        public string TRSACC { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)   必须唯一
        /// </summary>
        public string YURREF { get; set; }
    }
}
