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
    /// 31.4.内部户MT940业务详情查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS31_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTIAMIFD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIAMIFD";
        /// <summary>
        /// 31.4.内部户MT940业务详情查询响应内容
        /// </summary>
        public NTIAMIFDZ1 NTIAMIFDZ1 { get; set; }
        /// <summary>
        /// 31.4.内部户MT940业务详情查询响应内容
        /// </summary>
        public NTIAMIFDZ2 NTIAMIFDZ2 { get; set; }
        /// <summary>
        /// 31.4.内部户MT940业务详情查询响应集合
        /// </summary>
        [XmlElement("NTIAMIFDZ3")]
        public List<NTIAMIFDZ3> List { get; set; }
    }
    /// <summary>
    /// 31.4.内部户MT940业务详情查询响应内容
    /// </summary>
    public class NTIAMIFDZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期结算户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
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
        /// 请求状态 	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	O(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 用户名	Z(32)
        /// </summary>
        public string LGNNAM { get; set; }
        /// <summary>
        /// 用户姓名	Z(20)
        /// </summary>
        public string USRNAM { get; set; }
        /// <summary>
        /// 请求结果 	C(1) 
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 结果描述	Z(192)
        /// </summary>
        public string RTNTXT { get; set; }
    }
    /// <summary>
    /// 31.4.内部户MT940业务详情查询响应内容
    /// </summary>
    public class NTIAMIFDZ2
    {
        /// <summary>
        /// 内部户	C(35)
        /// </summary>
        public string INANBR { get; set; }
        /// <summary>
        /// 账务日期	D   与交易日期一致
        /// </summary>
        [XmlIgnore]
        public DateTime LGRDAT { get; set; }
        /// <summary>
        /// 账务日期	D, 对应<see cref="LGRDAT"/>
        /// </summary>
        [XmlElement("LGRDAT")]
        public string LGRDATStr
        {
            get
            {
                return this.LGRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LGRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 日初余额	M
        /// </summary>
        public decimal DASBAL { get; set; }
        /// <summary>
        /// 日终余额	M
        /// </summary>
        public decimal DAEBAL { get; set; }
        /// <summary>
        /// 交易总数	C(8)
        /// </summary>
        public int TTLCNT { get; set; }
    }
    /// <summary>
    /// 31.4.内部户MT940业务详情查询响应内容
    /// </summary>
    public class NTIAMIFDZ3
    {
        /// <summary>
        /// 交易流水号	C(30)
        /// </summary>
        public string TRSNBR { get; set; }
        /// <summary>
        /// 交易时间	T
        /// </summary>
        public string TRSTIM { get; set; }
        /// <summary>
        /// 交易借贷方向	C(2)	D：借，C：贷 RD：借冲，RC：：贷冲
        /// </summary>
        public string TRSDIR { get; set; }
        /// <summary>
        /// 交易金额	M   	必须大于0，发送交易总额累计，根据交易借贷方向轧差
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 联机余额	M
        /// </summary>
        public decimal ONLBAL { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime VALDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="VALDAT"/>
        /// </summary>
        [XmlElement("VALDAT")]
        public string VALDATStr
        {
            get
            {
                return this.VALDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VALDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易代码	C(4)    SWIFT的交易码
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 开户行参考编号	C(16)
        /// </summary>
        public string BBNREF { get; set; }
        /// <summary>
        /// 账户行参考编号	C(16)
        /// </summary>
        public string ABNREF { get; set; }
        /// <summary>
        /// 补充说明	C(34)
        /// </summary>
        public string REFINF { get; set; }
        /// <summary>
        /// 附加说明1	C(65)
        /// </summary>
        public string INFAP1 { get; set; }
        /// <summary>
        /// 附加说明2	C(65)
        /// </summary>
        public string INFAP2 { get; set; }
        /// <summary>
        /// 附加说明3	C(65)
        /// </summary>
        public string INFAP3 { get; set; }
        /// <summary>
        /// 附加说明4	C(65)
        /// </summary>
        public string INFAP4 { get; set; }
        /// <summary>
        /// 附加说明5	C(65)
        /// </summary>
        public string INFAP5 { get; set; }
        /// <summary>
        /// 附加说明6	C(65)
        /// </summary>
        public string INFAP6 { get; set; }
    }
}