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
    /// 14.2.查询母子公司户口联机余额请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ14_2 : CMBBase<RQINFO>, IRequest<RS14_2>
    {
        /// <summary>
        /// SDKNTQRYFSB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQRYFSB";
        /// <summary>
        /// 14.2.查询母子公司户口联机余额请求内容
        /// </summary>
        public NTQRYFSBX NTQRYFSBX { get; set; }
    }
    /// <summary>
    /// 14.2.查询母子公司户口联机余额请求内容
    /// </summary>
    public class NTQRYFSBX
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	C(5)
        /// </summary>
        public string CRPSEQ { get; set; }
    }
}
