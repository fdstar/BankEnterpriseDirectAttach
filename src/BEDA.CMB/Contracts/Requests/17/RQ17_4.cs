using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 17.4.关闭虚拟户请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_4 : CMBBase<RQINFO>, IRequest<RS17_4>
    {
        /// <summary>
        /// NTDMADLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMADLT";
        /// <summary>
        /// 17.4.关闭虚拟户请求内容
        /// </summary>
        public NTDMADLTX1 NTDMADLTX1 { get; set; }
        /// <summary>
        /// 17.4.关闭虚拟户请求集合
        /// </summary>
        [XmlElement("NTDMADLTX2")]
        public List<NTDMADLTX2> List { get; set; }
    }
    /// <summary>
    /// 17.3.新增虚拟户请求内容
    /// </summary>
    public class NTDMADLTX1
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
    }
    /// <summary>
    /// 17.3.新增虚拟户请求内容
    /// </summary>
    public class NTDMADLTX2
    {
        /// <summary>
        /// 虚拟户编号	C(20)   指定具体的虚拟户，不能为默认虚拟户
        /// </summary>
        public string DMANBR { get; set; }
    }
}
