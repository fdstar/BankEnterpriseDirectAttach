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
    /// 18.9.查询电文明细请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ18_9 : CMBBase<RQINFO>, IRequest<RS18_9>
    {
        /// <summary>
        /// SDKSWPKGDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKSWPKGDTL";
        /// <summary>
        /// 18.9.查询电文明细请求内容
        /// </summary>
        public SWPKGDTLX1 SWPKGDTLX1 { get; set; }
    }
    /// <summary>
    /// 18.9.查询电文明细请求内容
    /// </summary>
    public class SWPKGDTLX1
    {
        /// <summary>
        /// 电文编号	C(30)
        /// </summary>
        public string SWFNBR { get; set; }
        /// <summary>
        /// 行内账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 境外账号	C(35)
        /// </summary>
        public string ACTNBR { get; set; }
    }
}
