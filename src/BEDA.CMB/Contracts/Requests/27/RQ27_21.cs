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
    /// 27.21.查询划拨关系列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_21 : CMBBase<RQINFO>, IRequest<RS27_21>
    {
        /// <summary>
        /// NTMTLRLS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLRLS";
        /// <summary>
        /// 27.21.查询划拨关系列表请求内容
        /// </summary>
        public NTMTLRLSY1 NTMTLRLSY1 { get; set; }
    }
    /// <summary>
    /// 27.21.查询划拨关系列表请求内容
    /// </summary>
    public class NTMTLRLSY1
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 下级账号分行号	C(2)    上级账号+上级分行号或下级账号+下级分行号必输其一
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 上级账号分行号	C(2)
        /// </summary>
        public string TOPBBK { get; set; }
        /// <summary>
        /// 上级账号	C(35)
        /// </summary>
        public string TOPEAC { get; set; }
    }
}
