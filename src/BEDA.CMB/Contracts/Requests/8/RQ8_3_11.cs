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
    /// 8.3.11.步步为赢收益率试算请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_3_11 : CMBBase<RQINFO>, IRequest<RS8_3_11>
    {
        /// <summary>
        /// NTQDIPRF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDIPRF";
        /// <summary>
        /// 8.3.11.步步为赢收益率试算请求内容
        /// </summary>
        public NTQDIPRFX NTQDIPRFX { get; set; }
    }
    /// <summary>
    /// 8.3.11.步步为赢收益率试算请求内容
    /// </summary>
    public class NTQDIPRFX
    {
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 资金账户号码	C(15)
        /// </summary>
        public string ACTNBR { get; set; }
        /// <summary>
        /// 证券账户号码	C(6)
        /// </summary>
        public string RIPACT { get; set; }
    }
}
