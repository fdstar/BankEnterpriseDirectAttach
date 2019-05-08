using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 28.1.2.关闭虚拟户响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_1_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDUMDLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDUMDLT";
        /// <summary>
        /// 28.1.2.关闭虚拟户响应内容
        /// </summary>
        public NTDUMDLTZ1 NTDUMDLTZ1 { get; set; }
    }
    /// <summary>
    /// 28.1.2.关闭虚拟户响应内容
    /// </summary>
    public class NTDUMDLTZ1
    {
        /// <summary>
        /// 流程实例号   	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DYANBR { get; set; }
        /// <summary>
        /// 请求状态         	C(3) 	附录A.5
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果     	C(1)	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误描述	Z(192)
        /// </summary>
        public string ERRTXT { get; set; }
    }
}
