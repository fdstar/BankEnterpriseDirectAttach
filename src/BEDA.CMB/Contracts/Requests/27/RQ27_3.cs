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
    /// 27.3.查询多级现金池业务控制账号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_3 : CMBBase<RQINFO>, IRequest<RS27_3>
    {
        /// <summary>
        /// NTMTLCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLCTL";
        /// <summary>
        /// 27.3.查询多级现金池业务控制账号请求内容
        /// </summary>
        public NTMTLCTLX1 NTMTLCTLX1 { get; set; }
    }
    /// <summary>
    /// 27.3.查询多级现金池业务控制账号请求内容
    /// </summary>
    public class NTMTLCTLX1
    {
        /// <summary>
        /// 业务类型	C(6)    只能输入N36040:多级现金池设置 或N36050：多级现金池划拨
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 账户筛选类型	C(1)
        /// S：筛选子账号；
        /// M：筛选母账号；
        /// R：筛选划拨关系
        /// 空：不筛选
        /// </summary>
        public string CHKTYP { get; set; }
    }
}
