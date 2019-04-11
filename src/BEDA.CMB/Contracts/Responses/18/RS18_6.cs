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
    /// 18.6.境外账户维护明细响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS18_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCACDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCACDTL";
        /// <summary>
        /// 18.6.境外账户维护明细响应内容
        /// </summary>
        public NTCACDTLZ1 NTCACDTLZ1 { get; set; }
    }
    /// <summary>
    /// 18.6.境外账户维护明细响应内容
    /// </summary>
    public class NTCACDTLZ1
    {
        /// <summary>
        /// 维护类型	C(3)	OPR:增加 UPD:更新 DLT:删除
        /// </summary>
        public string MNTTYP { get; set; }
        /// <summary>
        /// 行内分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 行内账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
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
        /// 参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 境外账号	C(35)
        /// </summary>
        public string CRSACC { get; set; }
        /// <summary>
        /// 境外账号名称	Z(100)
        /// </summary>
        public string CRSACN { get; set; }
        /// <summary>
        /// 币种	C(3)	A.47国际业务货币代码表
        /// </summary>
        public string CRSCCY { get; set; }
        /// <summary>
        /// 发报行名称	Z(100)
        /// </summary>
        public string CRSBNK { get; set; }
        /// <summary>
        /// 发报行SWIFT地址	Z(11)
        /// </summary>
        public string SWFADR { get; set; }
        /// <summary>
        /// 请求状态	C(3)	A.5 业务请求状态
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	A.6 业务处理结果  REQSTS=FIN时，RTNFLG才有意义
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 结果摘要	Z(92)   失败时返回错误原因
        /// </summary>
        public string RTNNAR { get; set; }
    }
}
