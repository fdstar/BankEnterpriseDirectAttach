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
    /// 28.1.4.综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_1_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMAQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAQRY";
        /// <summary>
        /// 28.1.4.综合查询响应集合
        /// </summary>
        [XmlElement("NTDMAQRYZ1")]
        public List<NTDMAQRYZ1> List { get; set; }
    }
    /// <summary>
    /// 28.1.4.综合查询响应内容
    /// </summary>
    public class NTDMAQRYZ1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务编码	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 操作类型	C(4)	DUMA：新增虚拟户; DUMD：关闭虚拟户; DUPY：付款; DUMR：退款;
        /// </summary>
        public string OPRTYP { get; set; }
        /// <summary>
        /// 金额	M   虚拟户退款为总金额，交易金额+利息
        /// </summary>
        public decimal? TRSAMT { get; set; }
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
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
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 请求状态	C(3)	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
    }
}
