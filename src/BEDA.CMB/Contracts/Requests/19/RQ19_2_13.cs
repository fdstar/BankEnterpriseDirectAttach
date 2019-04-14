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
    /// 19.2.13.托收申请请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_13 : CMBBase<RQINFO>, IRequest<RS19_2_13>
    {
        /// <summary>
        /// SDKRCVOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKRCVOPR";
        /// <summary>
        /// 19.2.13.托收申请请求内容
        /// </summary>
        public NTRCVOPRX NTRCVOPRX { get; set; }
        /// <summary>
        /// 19.2.13.托收申请请求集合
        /// </summary>
        [XmlElement("NTTKTINFX")]
        public List<NTTKTINFX> List { get; set; }
    }
    /// <summary>
    /// 19.2.13.托收申请请求内容
    /// </summary>
    public class NTRCVOPRX
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
        /// 分行号	C(2)    当是招行帐号时必输
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)   必须唯一
        /// </summary>
        public string YURREF { get; set; }
    }
}
