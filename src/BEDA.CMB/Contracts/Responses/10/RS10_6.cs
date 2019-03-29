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
    /// 10.6.母子公司现金池交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTCAMTRS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCAMTRS";
        /// <summary>
        /// 10.6.母子公司现金池交易查询响应集合
        /// </summary>
        [XmlElement("NTTRXPTRZ")]
        public List<NTTRXPTRZ> List { get; set; }
    }
    /// <summary>
    /// 10.6.母子公司现金池交易查询响应集合
    /// </summary>
    public class NTTRXPTRZ
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 协议序号	N(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 子公司交易户口	C(35)
        /// </summary>
        public string SCREAC { get; set; }
        /// <summary>
        /// 子公司户口名称	Z(62)
        /// </summary>
        public string SCRNAM { get; set; }
        /// <summary>
        /// 数据类型	C(1) 	
        /// P:母公司交易  
        /// S:子公司交易
        /// O:其他交易
        /// </summary>
        public string DTATYP { get; set; }
        /// <summary>
        /// 资金客户	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 资金账户序号	C(5) 
        /// </summary>
        public string ACTSEQ { get; set; }
        /// <summary>
        /// 交易户口	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 货币	C(2) 	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)  
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 账户所在分行	C(3) 
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账户核算部门	C(6)
        /// </summary>
        public string ACTBRN { get; set; }
        /// <summary>
        /// 交易种类	C(1)	A.34 交易种类
        /// </summary>
        public string TRXTYP { get; set; }
        /// <summary>
        /// 记账方向	C(1)	A.19 记账方向代码
        /// </summary>
        public string BOKDIR { get; set; }
        /// <summary>
        /// 冲正标志	C(1)
        /// </summary>
        public string RVSTAG { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 联机余额	M
        /// </summary>
        public decimal ONLBAL { get; set; }
        /// <summary>
        /// 联机额度	M
        /// </summary>
        public decimal ONLLMT { get; set; }
        /// <summary>
        /// 记帐日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime LGRDAT { get; set; }
        /// <summary>
        /// 记帐日期	D, 对应<see cref="LGRDAT"/>
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
        /// 记帐时间	C(17)
        /// </summary>
        [XmlIgnore]
        public DateTime LGRTIM { get; set; }
        /// <summary>
        /// 记帐时间	C(17), 对应<see cref="LGRTIM"/>
        /// </summary>
        [XmlElement("LGRTIM")]
        public string LGRTIMStr
        {
            get
            {
                return this.LGRTIM.ToString("yyyyMMddHHmmssfff");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmmssfff", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LGRTIM = tmp;
                }
            }
        }
        /// <summary>
        /// 记账序号	N(9)
        /// </summary>
        public string LGRSEQ { get; set; }
        /// <summary>
        /// 交易套号	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 交易流水	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
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
        /// 交易日期	D
        /// </summary>
        public string ETYDAT { get; set; }
        /// <summary>
        /// 交易时间	T
        /// </summary>
        public string ETYTIM { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="ETYDAT"/>和<see cref="ETYTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.ETYDAT, this.ETYTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 摘要代码	C(4)
        /// </summary>
        public string TXTCOD { get; set; }
        /// <summary>
        /// 交易摘要	Z(42)
        /// </summary>
        public string TRXTXT { get; set; }
        /// <summary>
        /// 详细摘要标志	C(1)
        /// </summary>
        public string TXTTAG { get; set; }
        /// <summary>
        /// 收付方帐号分行号	C(2)
        /// </summary>
        public string RPYBBK { get; set; }
        /// <summary>
        /// 收付方帐号     	C(35)
        /// </summary>
        public string RPYACC { get; set; }
        /// <summary>
        /// 收付方名称     	Z(62)
        /// </summary>
        public string RPYNAM { get; set; }
        /// <summary>
        /// 收付方开户行行号	C(20)
        /// </summary>
        public string RPYBBN { get; set; }
        /// <summary>
        /// 收付方开户行行名	Z(62)
        /// </summary>
        public string RPYBNK { get; set; }
        /// <summary>
        /// 收付方开户行地址	Z(62)
        /// </summary>
        public string RPYADR { get; set; }
        /// <summary>
        /// 保留字段	C(100)
        /// </summary>
        public string RSV100 { get; set; }
    }
}
