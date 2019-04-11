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
    /// 18.10.查询账单正文/原文请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ18_10 : CMBBase<RQINFO>, IRequest<RS18_10>
    {
        /// <summary>
        /// SDKSWPKGTXT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKSWPKGTXT";
        /// <summary>
        /// 18.10.查询账单正文/原文请求内容
        /// </summary>
        public SWPKGTXTX2 SWPKGTXTX2 { get; set; }
    }
    /// <summary>
    /// 18.10.查询账单正文/原文请求内容
    /// </summary>
    public class SWPKGTXTX2
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
        /// <summary>
        /// 是否取原文	C(1)	Y：是 N：否
        /// </summary>
        public string RAWFLG { get; set; }
        /// <summary>
        /// 是否取正文	C(1)	Y：是 N：否
        /// </summary>
        public string PRTFLG { get; set; }
    }
}
