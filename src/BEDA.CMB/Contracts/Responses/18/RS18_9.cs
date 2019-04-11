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
    /// 18.9.查询电文明细响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS18_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKSWPKGDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKSWPKGDTL";
        /// <summary>
        /// 18.9.查询电文明细响应内容
        /// </summary>
        public SWMT940SZ1 SWMT940SZ1 { get; set; }
        /// <summary>
        /// 18.9.查询电文明细响应集合
        /// </summary>
        [XmlElement("SWMT940DZ1")]
        public List<SWMT940DZ1> List { get; set; }
    }
    /// <summary>
    /// 18.9.查询电文明细响应内容
    /// </summary>
    public class SWMT940SZ1
    {
        /// <summary>
        /// 发报行编号	C(16)
        /// </summary>
        public string SDRREF { get; set; }
        /// <summary>
        /// 相关业务编号	C(16)
        /// </summary>
        public string RLTREF { get; set; }
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACTNBR { get; set; }
        /// <summary>
        /// 对帐单号码	N(5)
        /// </summary>
        public int STTNBR { get; set; }
        /// <summary>
        /// 分页序号	N(5)
        /// </summary>
        public int TRXSEQ { get; set; }
        /// <summary>
        /// 起始余额方向	C(1)
        /// </summary>
        public string BOPDIR { get; set; }
        /// <summary>
        /// 起始余额日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BOPDAT { get; set; }
        /// <summary>
        /// 起始余额日期	D, 对应<see cref="BOPDAT"/>
        /// </summary>
        [XmlElement("BOPDAT")]
        public string BOPDATStr
        {
            get
            {
                return this.BOPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BOPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 起始余额货币	C(3)
        /// </summary>
        public string BOPCCY { get; set; }
        /// <summary>
        /// 起始余额金额	M
        /// </summary>
        public decimal BOPAMT { get; set; }
        /// <summary>
        /// 起始余额类型F/M	C(3)    F=起始余额有效 M=中间余额
        /// </summary>
        public string BOPTYP { get; set; }
        /// <summary>
        /// 结束余额方向	C(1)
        /// </summary>
        public string BCLDIR { get; set; }
        /// <summary>
        /// 结束余额日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BCLDAT { get; set; }
        /// <summary>
        /// 结束余额日期	D, 对应<see cref="BCLDAT"/>
        /// </summary>
        [XmlElement("BCLDAT")]
        public string BCLDATStr
        {
            get
            {
                return this.BCLDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BCLDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束余额货币	C(3)
        /// </summary>
        public string BCLCCY { get; set; }
        /// <summary>
        /// 结束余额金额	M
        /// </summary>
        public decimal BCLAMT { get; set; }
        /// <summary>
        /// 结束余额类型F/M	C(3)    F=结束余额有效 M=中间余额
        /// </summary>
        public string BCLTYP { get; set; }
        /// <summary>
        /// 有效余额方向	C(1)
        /// </summary>
        public string BCADIR { get; set; }
        /// <summary>
        /// 有效余额日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? BCADAT { get; set; }
        /// <summary>
        /// 有效余额日期	D, 对应<see cref="BCADAT"/>
        /// </summary>
        [XmlElement("BCADAT")]
        public string BCADATStr
        {
            get
            {
                return this.BCADAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.BCADAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BCADAT = tmp;
                }
            }
        }
        /// <summary>
        /// 有效余额货币	C(3)
        /// </summary>
        public string BCACCY { get; set; }
        /// <summary>
        /// 有效余额金额	M
        /// </summary>
        public decimal? BCAAMT { get; set; }
        /// <summary>
        /// 附加说明1	C(65)
        /// </summary>
        public string INFFL1 { get; set; }
        /// <summary>
        /// 附加说明2	C(65)
        /// </summary>
        public string INFFL2 { get; set; }
        /// <summary>
        /// 附加说明3	C(65)
        /// </summary>
        public string INFFL3 { get; set; }
        /// <summary>
        /// 附加说明4	C(65)
        /// </summary>
        public string INFFL4 { get; set; }
        /// <summary>
        /// 附加说明5	C(65)
        /// </summary>
        public string INFFL5 { get; set; }
        /// <summary>
        /// 附加说明6	C(65)
        /// </summary>
        public string INFFL6 { get; set; }
        /// <summary>
        /// 保留字段	C(20)
        /// </summary>
        public string RSVTXT { get; set; }
    }
    /// <summary>
    /// 18.9.查询电文明细响应内容
    /// </summary>
    public class SWMT940DZ1
    {
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
        /// 记帐日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EYIDAT { get; set; }
        /// <summary>
        /// 记帐日	D, 对应<see cref="EYIDAT"/>
        /// </summary>
        [XmlElement("EYIDAT")]
        public string EYIDATStr
        {
            get
            {
                return this.EYIDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EYIDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 借贷标志	C(2)
        /// </summary>
        public string BOKDIR { get; set; }
        /// <summary>
        /// 货币代号	C(1)
        /// </summary>
        public string CCYTAG { get; set; }
        /// <summary>
        /// 记帐金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 业务类型	C(4)
        /// </summary>
        public string TRXCOD { get; set; }
        /// <summary>
        /// 对方编号	C(16)
        /// </summary>
        public string RLTREF { get; set; }
        /// <summary>
        /// 我方编号	C(16)
        /// </summary>
        public string SDRREF { get; set; }
        /// <summary>
        /// 补充说明	C(34)
        /// </summary>
        public string REFINF { get; set; }
        /// <summary>
        /// 附加说明1	C(65)
        /// </summary>
        public string INFFL1 { get; set; }
        /// <summary>
        /// 附加说明2	C(65)
        /// </summary>
        public string INFFL2 { get; set; }
        /// <summary>
        /// 附加说明3	C(65)
        /// </summary>
        public string INFFL3 { get; set; }
        /// <summary>
        /// 附加说明4	C(65)
        /// </summary>
        public string INFFL4 { get; set; }
        /// <summary>
        /// 附加说明5	C(65)
        /// </summary>
        public string INFFL5 { get; set; }
        /// <summary>
        /// 附加说明6	C(65)
        /// </summary>
        public string INFFL6 { get; set; }
        /// <summary>
        /// 保留字段	C(20)
        /// </summary>
        public string RSVTXT { get; set; }
    }
}
