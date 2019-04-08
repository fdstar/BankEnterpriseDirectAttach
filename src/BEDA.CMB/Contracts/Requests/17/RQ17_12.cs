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
    /// 17.12.虚拟户利息试算请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_12 : CMBBase<RQINFO>, IRequest<RS17_12>
    {
        /// <summary>
        /// NTDMAINT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAINT";
        /// <summary>
        /// 17.12.虚拟户利息试算请求内容
        /// </summary>
        public NTDMAINTX1 NTDMAINTX1 { get; set; }
    }
    /// <summary>
    /// 17.12.虚拟户利息试算请求内容
    /// </summary>
    public class NTDMAINTX1
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)   填空表示查询该账号下所有虚拟户信息（不能为默认虚拟户编号）
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 周期类型	C(1)	Q:季度 M:月份
        /// </summary>
        public string PRDTYP { get; set; }
        /// <summary>
        /// 年份	C(4)
        /// </summary>
        public int PRDYER { get; set; }
        /// <summary>
        /// 第几期	C(2)    指定具体的季度或月份取值要与 PRDTYP 对应： Q:01-04 M:01-12
        /// </summary>
        public int PRDNBR { get; set; }
        /// <summary>
        /// 计息利率	F(11,7) 百分比，例如：3.15表示3.15%
        /// </summary>
        public decimal INTRAT { get; set; }
    }
}
