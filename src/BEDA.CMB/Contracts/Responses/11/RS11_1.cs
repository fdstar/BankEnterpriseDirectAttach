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
    /// 11.1.代理清算申请经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS11_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRAGP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRAGP";
        /// <summary>
        /// 11.1.代理清算申请经办响应集合   一次批量经办30笔以上的经办用查询代理清算批量经办处理结果
        /// </summary>
        [XmlElement("NTAGPRTNZ")]
        public List<NTAGPRTNZ> List { get; set; }
    }
    /// <summary>
    /// 11.1.代理清算申请经办响应内容
    /// </summary>
    public class NTAGPRTNZ
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 请求状态	C(3)	A.5 业务请求状态
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	C(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	A.6 业务处理结果
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误文本	C(92)
        /// </summary>
        public string ERRTXT { get; set; }
    }
}
