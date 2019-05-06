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
    /// 27.2.多级现金池综合交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTLTRS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLTRS";
        /// <summary>
        /// 27.2.多级现金池综合交易查询响应集合
        /// </summary>
        [XmlElement("NTMTLDTSZ1")]
        public List<NTMTLDTSZ1> List { get; set; }
    }
    /// <summary>
    /// 27.2.多级现金池综合交易查询响应内容
    /// </summary>
    public class NTMTLDTSZ1
    {
        /// <summary>
        /// 交易户口	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        public string TRSDAT { get; set; }
        /// <summary>
        /// 交易类型	C(4)	A.5 交易代码
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 划拨交易方式	C(1)
        /// A: 实时资金归集
        /// B: 实时资金补足
        /// C：定期资金归集
        /// D：定期资金补足
        /// E：手工上划，大额划拨
        /// F：手工下拨，大额划拨
        /// G：资金余额管理新协议余额上收
        /// </summary>
        public string TRXMOD { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 记账方向	C(1)    C：贷 D：借
        /// </summary>
        public string BOKDIR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 余额	M
        /// </summary>
        public decimal ONLBAL { get; set; }
        /// <summary>
        /// 冲账标志	C(1)
        /// </summary>
        public string RVSTAG { get; set; }
        /// <summary>
        /// 交易摘要	Z(42)
        /// </summary>
        public string TRXTXT { get; set; }
        /// <summary>
        /// 收（付）方账号	C(35)
        /// </summary>
        public string RPYACC { get; set; }
        /// <summary>
        /// 收（付）方名称	Z(62)
        /// </summary>
        public string RPYNAM { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime VLTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="VLTDAT"/>
        /// </summary>
        [XmlElement("VLTDAT")]
        public string VLTDATStr
        {
            get
            {
                return this.VLTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VLTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 票据号	C(20)
        /// </summary>
        public string CHKNBR { get; set; }
        /// <summary>
        /// 关联户口	C(35)
        /// </summary>
        public string RLTEAC { get; set; }
        /// <summary>
        /// 流水号	C(15)
        /// </summary>
        public string REFNBR { get; set; }
        /// <summary>
        /// 交易时间	T
        /// </summary>
        public string ETYTIM { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="TRSDAT"/>和<see cref="ETYTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TRSDAT, this.ETYTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 交易类型	Z(12)
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 交易分析码	C(6)
        /// </summary>
        public string TRSANL { get; set; }
        /// <summary>
        /// 内部摘要	Z(16)
        /// </summary>
        public string NARINN { get; set; }
        /// <summary>
        /// 扩展摘要	C(34)
        /// </summary>
        public string NAREXT { get; set; }
        /// <summary>
        /// 收付方帐号分行号	C(2)
        /// </summary>
        public string RPYBBK { get; set; }
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
        /// 母子帐号分行号	C(2)
        /// </summary>
        public string GSBBBK { get; set; }
        /// <summary>
        /// 母子公司帐号	C(35)
        /// </summary>
        public string GSBACC { get; set; }
        /// <summary>
        /// 母子公司名称	Z(62)
        /// </summary>
        public string GSBNAM { get; set; }
        /// <summary>
        /// 母子公司开户行行号	C(20)
        /// </summary>
        public string GSBBBN { get; set; }
        /// <summary>
        /// 母子公司开户行行名	Z(62)
        /// </summary>
        public string GSBBNK { get; set; }
        /// <summary>
        /// 母子公司开户行地址	Z(62)
        /// </summary>
        public string GSBADR { get; set; }
        /// <summary>
        /// 信息标志	C(1)
        /// </summary>
        public string INFFLG { get; set; }
        /// <summary>
        /// 头寸余额	F(17,2)
        /// </summary>
        public decimal NMLBAL { get; set; }
    }
}
