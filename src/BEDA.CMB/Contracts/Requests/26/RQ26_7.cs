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
    /// 26.7.批量作废经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ26_7 : CMBBase<RQINFO>, IRequest<RS26_7>
    {
        /// <summary>
        /// NTECKMOPDEL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKMOPDEL";
        /// <summary>
        /// 26.7.批量作废经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 26.7.批量作废经办请求集合
        /// </summary>
        [XmlElement("NTECKMDTX")]
        public List<NTECKMDTX> List { get; set; }
    }
    /// <summary>
    /// 26.7.批量作废经办请求内容
    /// </summary>
    public class NTECKMDTX
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 流水号	C(10)
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 支票号 	C(10)
        /// </summary>
        public string ECKNBR { get; set; }
    }
}
