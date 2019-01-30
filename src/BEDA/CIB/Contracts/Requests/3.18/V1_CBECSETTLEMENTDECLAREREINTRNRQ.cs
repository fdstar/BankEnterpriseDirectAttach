using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.18.5跨境电商结汇还原报送补录请求主体
    /// </summary>
    public class V1_CBECSETTLEMENTDECLAREREINTRNRQ : IRequest<V1_CBECSETTLEMENTDECLAREREINTRNRS>
    {
        /// <summary>
        /// 3.18.5跨境电商结汇还原报送补录请求主体
        /// </summary>
        public CBECSETTLEMENTDECLAREREINTRNRQ CBECSETTLEMENTDECLAREREINTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.18.5跨境电商结汇还原报送补录请求主体
    /// </summary>
    public class CBECSETTLEMENTDECLAREREINTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.18.5跨境电商结汇还原报送补录请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECSETTLEMENTDECLAREREINTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.18.5跨境电商结汇还原报送补录请求内容
    /// </summary>
    public class CBECSETTLEMENTDECLAREREINTRN_RQBODY
    {
        /// <summary>
        /// 结售汇银行流水号	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string EXCHANGEBANKLSH { get; set; }
        /// <summary>
        /// 地区机构号，5位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string BRANCH_NO { get; set; }
        /// <summary>
        /// 证件类型代码(目前仅支持0值，表示身份证或组织机构代码)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public int ID_TYPE { get; set; }
        /// <summary>
        /// 证件号码 必输
        /// 1）身份证：长度18位，由全部数字或数字加最末一位大写英文字符组成。
        /// 2）组织机构代码：000000000“+支付机构组织机构代码
        /// </summary>
        [XmlElement(Order = 3)]
        public string ID_CODE { get; set; }
        /// <summary>
        /// 补充证件号码	非必输
        /// 当证件类型为“中国护照”时不允许为空，需填写境外永久居留证号码；只允许输入大写字母和数字、中文。
        /// </summary>
        [XmlElement(Order = 4)]
        public string ADD_ID_CODE { get; set; }
        /// <summary>
        /// 国家地区代码 3位数字，默认中国-156 必输  请参考附件 结售汇国家地区代码
        /// </summary>
        [XmlElement(Order = 5)]
        public string COUNTRY_CODE { get; set; } = "156";
        /// <summary>
        /// 姓名 必输
        /// 只允许录入汉字、字母（半角）或符号（仅支持半角格式的点“.”和“-”以及中文格式的“·”）中间允许有空格
        /// </summary>
        [XmlElement(Order = 6)]
        public string PERSON_NAME { get; set; }
        /// <summary>
        /// 币种 参见银行币种代码表，币种不能为“人民币”。	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 结汇金额, 大于0	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal SETTLEMENT_AMT { get; set; }
        /// <summary>
        /// 结汇资金属性代码  必输，只能输入以下值:
        /// 110	货物贸易
        /// 121	运输
        /// 122	旅游
        /// 123	金融和保险服务
        /// 124	专有权利使用费和特许费
        /// 125	咨询服务
        /// 126	其他服务
        /// </summary>
        [XmlElement(Order = 9)]
        public int CAPITAL_PROP_CODE { get; set; }
        /// <summary>
        /// 结汇资金形态，目前只支持02-汇入资金（包括外汇票据）,默认02  必输
        /// 字典：
        /// 01-外币现钞
        /// 02-汇入资金（包括外汇票据）
        /// 03-账户资金
        /// 04-旅行支票
        /// </summary>
        [XmlElement(Order = 10)]
        public string SALE_SETTLE_CODE { get; set; } = "02";
        /// <summary>
        /// 结汇人民币账户 	非必输
        /// </summary>
        [XmlElement(Order = 11)]
        public string SETTLEMENT_CNY_ACCT_NO { get; set; }
        /// <summary>
        /// 个人外汇账户账号 结汇资金形态为“账户资金”时不允许为空 非必输
        /// </summary>
        [XmlElement(Order = 12)]
        public string FCY_ACCT_NO { get; set; }
        /// <summary>
        /// 支付机构组织机构代码	必输
        /// </summary>
        [XmlElement(Order = 13)]
        public string PAY_ORG_CODE { get; set; }
        /// <summary>
        /// 外汇局批件号/备案表号/业务编号	非必输
        /// </summary>
        [XmlElement(Order = 14)]
        public string SAFE_BIZ_NO { get; set; }
        /// <summary>
        /// 业务办理时间,YYYY-MM-DD 业务办理日期不能大于当前日期 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DEAL_DATE { get; set; }
        /// <summary>
        /// 业务办理时间,YYYY-MM-DD 业务办理日期不能大于当前日期, 对应<see cref="DEAL_DATE"/>	必输 
        /// </summary>
        [XmlElement("DEAL_DATE", Order = 15)]
        public string DEAL_DATEStr
        {
            get
            {
                return this.DEAL_DATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DEAL_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 备注 非必输
        /// </summary>
        [XmlElement(Order = 16)]
        public string MEMO { get; set; }
        /// <summary>
        /// 补录原因代码, 必输
        /// 01-应急预案启动后补录
        /// 02-脱机操作
        /// 03-差错业务撤销后补录
        /// 04-其他
        /// </summary>
        [XmlElement(Order = 17)]
        public string REIN_REASON_CODE { get; set; }
        /// <summary>
        /// 补录说明,当补录原因为“其他”时不允许为空 非必输
        /// </summary>
        [XmlElement(Order = 18)]
        public string REIN_REMARK { get; set; }
    }
}
