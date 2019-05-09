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
    /// 31.1.发送内部户日初日终余额及交易报文经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ31_1 : CMBBase<RQINFO>, IRequest<RS31_1>
    {
        /// <summary>
        /// NTIAMSTD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIAMSTD";
        /// <summary>
        /// 31.1.发送内部户日初日终余额及交易报文经办请求内容
        /// </summary>
        public NTIAMSTDX1 NTIAMSTDX1 { get; set; }
        /// <summary>
        /// 31.1.发送内部户日初日终余额及交易报文经办请求内容
        /// </summary>
        public NTIAMSTDX2 NTIAMSTDX2 { get; set; }
        /// <summary>
        /// 31.1.发送内部户日初日终余额及交易报文经办请求集合
        /// </summary>
        [XmlElement("NTIAMSTDX3")]
        public List<NTIAMSTDX3> List { get; set; }
    }
    /// <summary>
    /// 31.1.发送内部户日初日终余额及交易报文经办请求内容
    /// </summary>
    public class NTIAMSTDX1
    {
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 内部户	C(35)
        /// </summary>
        public string INANBR { get; set; }
        /// <summary>
        /// 币种	C(2)    	要求与交易币种一致
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易日期	D   要求余额日期与交易日期一致
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRSDAT"/>
        /// </summary>
        [XmlElement("TRSDAT")]
        public string TRSDATStr
        {
            get
            {
                return this.TRSDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 批次开始标志	C(1)	Y：开始，N：续传   批次开始标志为Y时输入X2接口
        /// </summary>
        public string BCHBEG { get; set; }
        /// <summary>
        /// 批次结束标志	C(1)	Y：结束，N：未结束  批次结束标志为Y时输入NTIAMSTDX2接口
        /// </summary>
        public string BCHEND { get; set; }
        /// <summary>
        /// 流程实例号	C(10)	批次开始标志为Y时，输入空； 批次开始标志为N时，输入开始经办成功返回的流程实例号（保证同一大批次使用同一个流程实例号，即批次号）
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)   批次开始标志为Y时,保证唯一； 批次开始标志为N时，输入开始经办成功时的业务参考号（保证同一批次使用同一个业务参考号）
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 总金额	M   大批次交易总额（借贷轧差） 并且 日初余额+总金额=日终余额
        /// </summary>
        public decimal TTLAMT { get; set; }
        /// <summary>
        /// 总笔数	C(8)    大批次交易笔数
        /// </summary>
        public int TTLCNT { get; set; }
        /// <summary>
        /// 总次数	C(5)    	一个大批次下交易分小批次后推送次数
        /// </summary>
        public int TTLNUM { get; set; }
        /// <summary>
        /// 本次金额	M   小批次交易总额
        /// </summary>
        public decimal CURAMT { get; set; }
        /// <summary>
        /// 本次条数	C(8)    	小批次交易笔数
        /// </summary>
        public int CURCNT { get; set; }
    }
    /// <summary>
    /// 31.1.发送内部户日初日终余额及交易报文经办请求内容
    /// </summary>
    public class NTIAMSTDX2
    {
        /// <summary>
        /// 日初余额	M
        /// </summary>
        public decimal DASBAL { get; set; }
        /// <summary>
        /// 日终余额	M
        /// </summary>
        public decimal DAEBAL { get; set; }
    }
    /// <summary>
    /// 31.1.发送内部户日初日终余额及交易报文经办请求内容
    /// </summary>
    public class NTIAMSTDX3
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
