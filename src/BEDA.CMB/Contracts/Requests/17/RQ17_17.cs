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
    /// 17.17.虚拟户解除公司卡关联请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_17 : CMBBase<RQINFO>, IRequest<RS17_17>
    {
        /// <summary>
        /// NTDCDDLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDCDDLT";
        /// <summary>
        /// 17.17.虚拟户解除公司卡关联请求内容
        /// </summary>
        public NTDCDDLTX1 NTDCDDLTX1 { get; set; }
        /// <summary>
        /// 17.17.虚拟户解除公司卡关联请求集合
        /// </summary>
        [XmlElement("NTDCDDLTX2")]
        public List<NTDCDDLTX2> List { get; set; }
    }
    /// <summary>
    /// 17.17.虚拟户解除公司卡关联请求内容
    /// </summary>
    public class NTDCDDLTX1
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
    /// 17.17.虚拟户解除公司卡关联请求内容
    /// </summary>
    public class NTDCDDLTX2
    {
        /// <summary>
        /// 公司卡号	C(35)
        /// </summary>
        public string CDSNBR { get; set; }
    }
}
