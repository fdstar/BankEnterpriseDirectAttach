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
    /// 12.1.1.支付机构经办结售汇申请请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_1_1 : CMBBase<RQINFO>, IRequest<RS12_1_1>
    {
        /// <summary>
        /// NTOPRJSH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRJSH";
        /// <summary>
        /// 12.1.1.支付机构经办结售汇申请请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 12.1.1.支付机构经办结售汇申请请求内容
        /// </summary>
        public NTJSHOPRX NTJSHOPRX { get; set; }
    }
    /// <summary>
    /// 12.1.1.支付机构经办结售汇申请请求内容
    /// </summary>
    public class NTJSHOPRX
    {
        /// <summary>
        /// 分行号	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 申请人客户号	C(10)   可由查询客户号信息获取
        /// </summary>
        public string APPNBR { get; set; }
        /// <summary>
        /// 网上业务编号	C(30)   参考号前三位按下面的个规则来填写，否则有可能会经办不通过
        /// 1、结汇时，BEX
        /// 2、售汇时，VEN
        /// </summary>
        public string APPCNO { get; set; }
        /// <summary>
        /// 受理机构	C(6)
        /// </summary>
        public string PRCBRN { get; set; }
        /// <summary>
        /// 申请类型	C(4)	EXSL：结汇 EXBY：购汇
        /// </summary>
        public string JSHCOD { get; set; }
        /// <summary>
        /// 资金来源性质	C(3)
        /// 310:货物贸易
        /// 320:服务贸易
        /// 330:收益与经常转移
        /// 400:资本与金融项目
        /// </summary>
        public string SRCNAT { get; set; }
        /// <summary>
        /// 汇率类型 	C(1)	0:按实际交易时汇率  1:按约定汇率
        /// </summary>
        public string RATTYP { get; set; }
        /// <summary>
        /// 约定汇率 	F(8,4)	汇率类型为1时必填.  请按100外币兑换多少人民币的数字格式填写。例如，美元交易时可录入665.24
        /// </summary>
        public decimal? AGRRAT { get; set; }
        /// <summary>
        /// 结售汇类型	C(1)
        /// 0:实时交割即期
        /// 1:非实时交割即期
        /// 2:远期
        /// 3:择期
        /// </summary>
        public string JSHTYP { get; set; }
        /// <summary>
        /// 约定交割日起	D
        /// 1、结售汇类型为0时，为空
        /// 2、结售汇类型为1时，必须大于等于当天T，小于等于T+2
        /// 3、其它：必须大于T+2
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
        /// 1、结售汇类型为0时，为空
        /// 2、结售汇类型为3时，必须大于约定交割起始日
        /// 3、其它：必须等于约定交割起始日
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
        /// 卖出货币	C(2)
        /// 购汇时：
        /// 10:人民币
        /// 结汇时：
        /// 21：港元
        /// 29：澳大利亚元
        /// 32：美元
        /// 35：欧元
        /// 39：加拿大元
        /// 43：英镑
        /// 65：日元
        /// 69：新加坡元
        /// 87：瑞士法郎
        /// </summary>
        public string SELCCY { get; set; }
        /// <summary>
        /// 卖出货币钞汇	C(1)	结汇时： 2：现汇
        /// </summary>
        public string SELCTP { get; set; }
        /// <summary>
        /// 卖出金额	M   与买入金额二者必填其一，日元必须为整数，如果是支付机构集中收付做的结汇时，母业务的卖出金额与卖出币种要必输
        /// </summary>
        public decimal? SELAMT { get; set; }
        /// <summary>
        /// 客户卖出账号	C(35)   与其他出款方式二者必填其一
        /// </summary>
        public string SELACC { get; set; }
        /// <summary>
        /// 其他出款方式	Z(100)  与客户卖出账号二者必填其一
        /// </summary>
        public string OUMOTW { get; set; }
        /// <summary>
        /// 买入货币	C(2)
        /// 购汇时：
        /// 21：港元
        /// 29：澳大利亚元
        /// 32：美元
        /// 35：欧元
        /// 39：加拿大元
        /// 43：英镑
        /// 65：日元
        /// 69：新加坡元
        /// 87：瑞士法郎
        /// 结汇时：
        /// 10:人民币
        /// </summary>
        public string BUYCCY { get; set; }
        /// <summary>
        /// 买入货币钞汇	C(1)	购汇时：2：现汇 结汇时不填或者填0
        /// </summary>
        public string BUYCTP { get; set; }
        /// <summary>
        /// 买入金额 	M   与卖出金额二者必填其一，日元必须为整数
        /// </summary>
        public decimal? BUYAMT { get; set; }
        /// <summary>
        /// 客户买入账号	C(35)   与其他入款方式二者必填其一
        /// </summary>
        public string BUYACC { get; set; }
        /// <summary>
        /// 其他入款方式	Z(100)  与客户买入账号二者必填其一
        /// </summary>
        public string INMOTW { get; set; }
        /// <summary>
        /// 保证方式	C(1)
        /// D：定期保证金
        /// H：活期保证金
        /// Q：其他保证方式
        /// S：授信额度
        /// 结售汇类型为0：实时交割即期时为空，否则必填
        /// </summary>
        public string GUATYP { get; set; }
        /// <summary>
        /// 保证比例	N(3)	百分比整数，不带%   结售汇类型为0：实时交割即期时为空，否则必填
        /// </summary>
        public int? GUARAT { get; set; }
        /// <summary>
        /// 保证金来源	C(1)
        /// 1、保证方式为D时 (1：从活期户中收取定期保证金2：以现有定期保证金作为保证)
        /// 2、保证方式为H时 (0: 从活期户中收取活期保证金)
        /// 3、其它：(为空)
        /// </summary>
        public string MGNSRC { get; set; }
        /// <summary>
        /// 扣收活期保证金账号	C(35)   保证金来源为0时，必填
        /// </summary>
        public string CURACC { get; set; }
        /// <summary>
        /// 扣收定期保证金账号	C(35)   保证金来源为1时，必填
        /// </summary>
        public string REGACC { get; set; }
        /// <summary>
        /// 定期保证金到期日	D   保证金来源为1时，必填，且必须大于当前日期
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
        /// 现有定期保证金账号	C(35)   保证金来源为2时，必填
        /// </summary>
        public string AVAACC { get; set; }
        /// <summary>
        /// 其他保证方式描述	Z(100)  保证方式为Q时，必填，否则为空
        /// </summary>
        public string OTHDSP { get; set; }
        /// <summary>
        /// 保留字段	C(50)   第一位按如下定义输入：1：支付机构跨境电商外汇集中收付 其他不是支付机构的业务
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
