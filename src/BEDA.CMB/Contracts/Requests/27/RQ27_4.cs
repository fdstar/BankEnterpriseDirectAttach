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
    /// 27.4.查询内部户信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_4 : CMBBase<RQINFO>, IRequest<RS27_4>
    {
        /// <summary>
        /// NTINAINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTINAINF";
        /// <summary>
        /// 27.4.查询内部户信息请求内容
        /// </summary>
        public NTINAINFY1 NTINAINFY1 { get; set; }
    }
    /// <summary>
    /// 27.4.查询内部户信息请求内容
    /// </summary>
    public class NTINAINFY1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 内部户编号	C(10)
        /// </summary>
        public string INANBR { get; set; }
    }
}
