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
    /// 17.15.查询虚拟户关联公司卡列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_15 : CMBBase<RQINFO>, IRequest<RS17_15>
    {
        /// <summary>
        /// NTDCDRLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDCDRLT";
        /// <summary>
        /// 17.15.查询虚拟户关联公司卡列表请求内容
        /// </summary>
        public NTDCDRLTX1 NTDCDRLTX1 { get; set; }
    }
    /// <summary>
    /// 17.15.查询虚拟户关联公司卡列表请求内容
    /// </summary>
    public class NTDCDRLTX1
    {
        /// <summary>
        /// 内部账簿账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号 	C(20)
        /// </summary>
        public string DMANBR { get; set; }
    }
}
