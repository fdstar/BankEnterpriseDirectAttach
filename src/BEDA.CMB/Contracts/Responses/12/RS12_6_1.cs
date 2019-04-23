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
    /// 12.6.1.支付机构查询结售汇申请明细响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_6_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTJSHDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJSHDTL";
        /// <summary>
        /// 12.6.1.支付机构查询结售汇申请明细响应内容
        /// </summary>
        public NTJSHDTLZ NTJSHDTLZ { get; set; }
    }
    /// <summary>
    /// 12.6.1.支付机构查询结售汇申请明细响应内容
    /// </summary>
    public class NTJSHDTLZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 申请人客户号	C(10)
        /// </summary>
        public string APPNBR { get; set; }
        /// <summary>
        /// 客户名称	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 网上业务编号	C(30)
        /// </summary>
        public string APPCNO { get; set; }
        /// <summary>
        /// 结售汇编号	C(10)
        /// </summary>
        public string JSHNBR { get; set; }
        /// <summary>
        /// 受理机构	C(6)
        /// </summary>
        public string PRCBRN { get; set; }
        /// <summary>
        /// 申请类型	C(4)	EXSL：结汇申请 EXBY: 购汇申请
        /// </summary>
        public string JSHCOD { get; set; }
        /// <summary>
        /// 资金来源性质	C(3)
        /// 310:物贸易
        /// 320:务贸易
        /// 330:收益与经常转移
        /// 400:资本与金融项目
        /// </summary>
        public string SRCNAT { get; set; }
        /// <summary>
        /// 汇率类型	C(1)
        /// 0:按实际交易时汇率
        /// 1:按约定汇率
        /// </summary>
        public string RATTYP { get; set; }
        /// <summary>
        /// 约定汇率	F(8,4)
        /// </summary>
        public decimal? AGRRAT { get; set; }
        /// <summary>
        /// 结售汇类型 	C(1)
        /// 0：实时交割即期  
        /// 1：非实时交割即期
        /// 2：远期
        /// 3：择期
        /// </summary>
        public string JSHTYP { get; set; }
        /// <summary>
        /// 约定交割日起	D
        /// </summary>
        [XmlIgnore]
        public DateTime? BGNDAT { get; set; }
        /// <summary>
        /// 约定交割日起	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.BGNDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 约定交割日止	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDAT { get; set; }
        /// <summary>
        /// 约定交割日止	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 卖出货币	C(2)	A.3 货币代码表
        /// </summary>
        public string SELCCY { get; set; }
        /// <summary>
        /// 卖出货币钞汇	C(1)
        /// </summary>
        public string SELCTP { get; set; }
        /// <summary>
        /// 卖出金额	M
        /// </summary>
        public decimal? SELAMT { get; set; }
        /// <summary>
        /// 客户卖出账号	C(35)
        /// </summary>
        public string SELACC { get; set; }
        /// <summary>
        /// 其他出款方式	Z(100)
        /// </summary>
        public string OUMOTW { get; set; }
        /// <summary>
        /// 买入货币	C(2)	A.3 货币代码表
        /// </summary>
        public string BUYCCY { get; set; }
        /// <summary>
        /// 买入货币钞汇	C(1)    2：现汇
        /// </summary>
        public string BUYCTP { get; set; }
        /// <summary>
        /// 买入金额	M
        /// </summary>
        public decimal? BUYAMT { get; set; }
        /// <summary>
        /// 客户买入账号	C(35)
        /// </summary>
        public string BUYACC { get; set; }
        /// <summary>
        /// 其他入款方式 	Z(100)	
        /// </summary>
        public string INMOTW { get; set; }
        /// <summary>
        /// 保证方式	C(1)
        /// D：定期保证金
        /// H：活期保证金
        /// Q：其他保证方式
        /// S：授信额度
        /// </summary>
        public string GUATYP { get; set; }
        /// <summary>
        /// 保证比例 (%)	N(3)
        /// </summary>
        public int? GUARAT { get; set; }
        /// <summary>
        /// 保证金来源	C(1)
        /// </summary>
        public string MGNSRC { get; set; }
        /// <summary>
        /// 扣收活期保证金账号	C(35)
        /// </summary>
        public string CURACC { get; set; }
        /// <summary>
        /// 扣收定期保证金账号	C(35)
        /// </summary>
        public string REGACC { get; set; }
        /// <summary>
        /// 定期保证金到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? REGDAT { get; set; }
        /// <summary>
        /// 定期保证金到期日	D, 对应<see cref="REGDAT"/>
        /// </summary>
        [XmlElement("REGDAT")]
        public string REGDATStr
        {
            get
            {
                return this.REGDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.REGDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.REGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 现有定期保证金账号	C(35)
        /// </summary>
        public string AVAACC { get; set; }
        /// <summary>
        /// 其他保证方式描述	Z(100)
        /// </summary>
        public string OTHDSP { get; set; }
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
        /// 期望日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EPTDAT { get; set; }
        /// <summary>
        /// 期望日	D, 对应<see cref="EPTDAT"/>
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.EPTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.EPTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EPTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 附件标志	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 影像套 ID	C(40)
        /// </summary>
        public string ATHSET { get; set; }
        /// <summary>
        /// 申请状态	C(1)
        /// </summary>
        public string APPSTS { get; set; }
        /// <summary>
        /// 拒绝原因	Z(120)
        /// </summary>
        public string RJTRSN { get; set; }
    }
}
