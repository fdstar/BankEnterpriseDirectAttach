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
    /// 17.23.查询虚拟户关联付款方信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_23 : CMBBase<RQINFO>, IRequest<RS17_23>
    {
        /// <summary>
        /// NTDMARLQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMARLQ";
        /// <summary>
        /// 17.23.查询虚拟户关联付款方信息请求内容
        /// </summary>
        public NTDMARLQY1 NTDMARLQY1 { get; set; }
    }
    /// <summary>
    /// 17.23.查询虚拟户关联付款方信息请求内容
    /// </summary>
    public class NTDMARLQY1
    {
        /// <summary>
        /// 分行号	C(2) 
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C (20)
        /// </summary>
        public string DMANBR { get; set; }
    }
}
