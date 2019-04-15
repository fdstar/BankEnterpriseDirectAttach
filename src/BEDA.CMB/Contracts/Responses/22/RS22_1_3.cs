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
    /// 22.1.3.贴现申请清单综合查询列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_1_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBSCQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBSCQRY";
        /// <summary>
        /// 22.1.3.贴现申请清单综合查询列表响应集合
        /// </summary>
        [XmlElement("NTBSCQRYZ1")]
        public List<NTBSCQRYZ1> List { get; set; }
        /// <summary>
        /// 22.1.3.贴现申请清单综合查询列表响应内容 	续传时返回
        /// </summary>
        public Requests.NTBSCQRYY1 NTBSCQRYY1 { get; set; }
    }
    /// <summary>
    /// 22.1.3.贴现申请清单综合查询列表响应内容
    /// </summary>
    public class NTBSCQRYZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 账号分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 贴现票据张数	F(5,0)  取经办时保存到BSRREQDTA字段的值
        /// </summary>
        public int BILCNT { get; set; }
        /// <summary>
        /// 贴现总金额	M
        /// </summary>
        public decimal TOLAMT { get; set; }
        /// <summary>
        /// 贴现日期	D
        /// </summary>
        public string CRTDAT { get; set; }
        /// <summary>
        /// 贴现时间	T
        /// </summary>
        public string CRTTIM { get; set; }
        /// <summary>
        /// 贴现时间 由<see cref="CRTDAT"/>和<see cref="CRTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? DiscountTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.CRTDAT, this.CRTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 业务请求状态	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务请求结果	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 待处理操作步骤	C(6)
        /// </summary>
        public string OPRSTP { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误描述	Z(192)  失败时展示具体错误原因，从NCREFDTAP里取
        /// </summary>
        public string ERRDSP { get; set; }
    }
}
