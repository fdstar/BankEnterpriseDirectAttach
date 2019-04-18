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
    /// 8.4.5.业务查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// QueryFixNotify
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "QueryFixNotify";
        /// <summary>
        /// 8.4.5.业务查询响应集合
        /// </summary>
        [XmlElement("NTQRYFNCZ")]
        public List<NTQRYFNCZ> List { get; set; }
    }
    /// <summary>
    /// 8.4.5.业务查询响应内容
    /// </summary>
    public class NTQRYFNCZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 操作类型	C(3)
        /// </summary>
        public string OPRTYP { get; set; }
        /// <summary>
        /// 活期账号分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 定期账号的分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期账号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 通知存款类型	C(2)	01: 1 天通知存款 07: 7 天通知存款
        /// </summary>
        public string INFTYP { get; set; }
        /// <summary>
        /// 通知状态	C(1)
        /// A: 通知有效
        /// C: 通知已取消
        /// V: 通知已冲消
        /// D: 已删除
        /// E: 已支取
        /// </summary>
        public string INFSTS { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 请求状态	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 经办日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
