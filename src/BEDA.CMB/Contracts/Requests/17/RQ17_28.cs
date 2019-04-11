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
    /// 17.28.查询公司卡关联付款方信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_28 : CMBBase<RQINFO>, IRequest<RS17_28>
    {
        /// <summary>
        /// NTDMDRQD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMDRQD";
        /// <summary>
        /// 17.28.查询公司卡关联付款方信息请求内容
        /// </summary>
        public NTDMDRQDX1 NTDMDRQDX1 { get; set; }
    }
    /// <summary>
    /// 17.28.查询公司卡关联付款方信息请求内容
    /// </summary>
    public class NTDMDRQDX1
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
        /// 虚拟户	C(20)   首次查询空，续传查询传上次查询返回续传键值 （虚拟户、公司卡号、关联付方账号必须同时为空或同时有值）
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 公司卡号	C(20)   首次查询空，续传查询传上次查询返回续传键值 （虚拟户、公司卡号、关联付方账号必须同时为空或同时有值）
        /// </summary>
        public string CDSNBR { get; set; }
        /// <summary>
        /// 关联付款方账号	C(35)   首次查询空，续传查询传上次查询返回续传键值 （虚拟户、公司卡号、关联付方账号必须同时为空或同时有值）
        /// </summary>
        public string DBTACC { get; set; }
    }
}
