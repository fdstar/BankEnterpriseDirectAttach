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
    /// 17.16.设置虚拟户关联公司卡请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_16 : CMBBase<RQINFO>, IRequest<RS17_16>
    {
        /// <summary>
        /// NTDCDADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDCDADD";
        /// <summary>
        /// 17.16.设置虚拟户关联公司卡请求内容
        /// </summary>
        public NTDCDADDX1 NTDCDADDX1 { get; set; }
        /// <summary>
        /// 17.16.设置虚拟户关联公司卡请求集合
        /// </summary>
        [XmlElement("NTDCDADDX2")]
        public List<NTDCDADDX2> List { get; set; }
    }
    /// <summary>
    /// 17.16.设置虚拟户关联公司卡请求内容
    /// </summary>
    public class NTDCDADDX1
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
    /// <summary>
    /// 17.16.设置虚拟户关联公司卡请求内容
    /// </summary>
    public class NTDCDADDX2
    {
        /// <summary>
        /// 公司卡号	C(35)
        /// </summary>
        public string CDSNBR { get; set; }
    }
}
