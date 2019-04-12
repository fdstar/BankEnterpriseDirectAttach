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
    /// 19.1.2.根据客户编号查询账号信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_1_2 : CMBBase<RQINFO>, IRequest<RS19_1_2>
    {
        /// <summary>
        /// SDKRTVACI
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKRTVACI";
        /// <summary>
        /// 19.1.2.根据客户编号查询账号信息请求内容
        /// </summary>
        public NTRTVACIX NTRTVACIX { get; set; }
    }
    /// <summary>
    /// 19.1.2.根据客户编号查询账号信息请求内容
    /// </summary>
    public class NTRTVACIX
    {
        /// <summary>
        /// 客户编号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
    }
}
