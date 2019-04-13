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
    /// 19.2.4.背书转让经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_4 : CMBBase<RQINFO>, IRequest<RS19_2_4>
    {
        /// <summary>
        /// SDKWRTOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKWRTOPR";
        /// <summary>
        /// 19.2.4.背书转让经办请求内容
        /// </summary>
        public NTWRTOPRX NTWRTOPRX { get; set; }
        /// <summary>
        /// 19.2.4.背书转让经办请求集合
        /// </summary>
        [XmlElement("NTTKTINFX")]
        public List<NTTKTINFX> List { get; set; }
    }
    /// <summary>
    /// 19.2.4.背书转让经办请求内容
    /// </summary>
    public class NTWRTOPRX
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
        /// 被背书人帐号	C(35)
        /// </summary>
        public string OBJACC { get; set; }
        /// <summary>
        /// 被背书人名称	Z(62)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 被背书人地址	Z(62)
        /// </summary>
        public string OBJADR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)   必须唯一
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 19.2.4.背书转让经办请求内容
    /// </summary>
    public class NTTKTINFX
    {
        /// <summary>
        /// 票据流水号	C(10)   经办票据信息查询
        /// </summary>
        public string SEQNBR { get; set; }
    }
}
