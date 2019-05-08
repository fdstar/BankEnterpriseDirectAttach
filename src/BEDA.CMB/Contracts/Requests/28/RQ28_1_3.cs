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
    /// 28.1.3.虚拟户查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_1_3 : CMBBase<RQINFO>, IRequest<RS28_1_3>
    {
        /// <summary>
        /// NTDUMQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDUMQRY";
        /// <summary>
        /// 28.1.3.虚拟户查询请求内容
        /// </summary>
        public NTDUMQRYY1 NTDUMQRYY1 { get; set; }
    }
    /// <summary>
    /// 28.1.3.虚拟户查询请求内容
    /// </summary>
    public class NTDUMQRYY1
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
        /// <summary>
        /// 虚拟户查询开始编号	C(20)   默认查询全部
        /// 如果查询单个虚拟户，则DANBEG与DANEND输入同一编号； 如果查询所有虚拟户，则DANBEG与DANEND均输入全*; 如果查询指定虚拟户区间，则DANBEG与DANEND分别填入起始编号与结束编号；
        /// </summary>
        public string DANBEG { get; set; } = "********************";
        /// <summary>
        /// 虚拟户查询结束编号	C(20)   默认查询全部
        /// </summary>
        public string DANEND { get; set; } = "********************";
    }
}
