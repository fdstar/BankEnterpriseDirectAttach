using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.1.4电子商业汇票票据正面信息查询响应主体
    /// </summary>
    public class V1_EBFACEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.4电子商业汇票票据正面信息查询响应主体
        /// </summary>
        public EBFACEQUERYTRNRS EBFACEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.4电子商业汇票票据正面信息查询响应主体
    /// </summary>
    public class EBFACEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.4电子商业汇票票据正面信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBFACEQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.4电子商业汇票票据正面信息查询响应内容
    /// </summary>
    public class EBFACEQUERYTRN_RSBODY
    {
        /// <summary>
        /// 30位票据号码
        /// </summary>
        [XmlElement(Order = 2)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据类型,4位(AC01:银票,AC02:商票)
        /// </summary>
        [XmlElement(Order = 3)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime DRAWDATE { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD, 对应<see cref="DRAWDATE"/>
        /// </summary>
        [XmlElement("DRAWDATE", Order = 5)]
        public string DRAWDATEStr
        {
            get
            {
                return this.DRAWDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DRAWDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 票据到期日 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 票据到期日 YYYY-MM-DD, 对应<see cref="DUEDATE"/>
        /// </summary>
        [XmlElement("DUEDATE", Order = 6)]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 转让标识 4位(EM00:可再转让,EM01:不可再转让)
        /// </summary>
        [XmlElement(Order = 7)]
        public string NEGTBL { get; set; }
        /// <summary>
        /// 票据状态,6位见附录：票据状态表
        /// </summary>
        [XmlElement(Order = 8)]
        public string BILLSTATUS { get; set; }
        /// <summary>
        /// 到期无条件支付委托 CC00
        /// </summary>
        [XmlElement(Order = 9)]
        public string ENTRSPAY { get; set; }
        /// <summary>
        /// 到期无条件支付承诺 CC00	非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string PROMSPAY { get; set; }
        /// <summary>
        /// 交易合同号
        /// </summary>
        [XmlElement(Order = 11)]
        public string CONTRACTID { get; set; }
        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement(Order = 12)]
        public string INVCCODE { get; set; }
        /// <summary>
        /// 出票人信息
        /// </summary>
        [XmlElement(Order = 13)]
        public CREDITACCT DRAWER { get; set; }
        /// <summary>
        /// 承兑人信息
        /// </summary>
        [XmlElement(Order = 14)]
        public CREDITACCT ACPTR { get; set; }
        /// <summary>
        /// 收款人信息 收款人不返回 CREDITINFO
        /// </summary>
        [XmlElement(Order = 15)]
        public CREDITACCT PAYEE { get; set; }
        /// <summary>
        /// 提示承兑日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime ACPTDATE { get; set; }
        /// <summary>
        /// 提示承兑日期 YYYY-MM-DD, 对应<see cref="ACPTDATE"/>
        /// </summary>
        [XmlElement("ACPTDATE", Order = 16)]
        public string ACPTDATEStr
        {
            get
            {
                return this.ACPTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ACPTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 出票保证人信息
        /// </summary>
        [XmlElement(Order = 17)]
        public CORRELATEACCT DGINFO { get; set; }
        /// <summary>
        /// 承兑保证人账户代号
        /// </summary>
        [XmlElement(Order = 18)]
        public CORRELATEACCT AGINFO { get; set; }
        /// <summary>
        /// 备注,最大256位
        /// </summary>
        [XmlElement(Order = 19)]
        public string MEMO { get; set; }
    }
    /// <summary>
    /// 包含评级信息的账户信息
    /// </summary>
    public class CREDITACCT
    {
        /// <summary>
        /// 客户类型，4位,见附录《电子票据汇票系统编码对照表-企业类型》
        /// </summary>
        [XmlElement(Order = 0)]
        public string CUSTTYPE { get; set; }
        /// <summary>
        /// 账户代号,最大32位
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称,最大60位
        /// </summary>
        [XmlElement(Order = 2)]
        public string NAME { get; set; }
        /// <summary>
        /// 开户行行号,最大12位
        /// </summary>
        [XmlElement(Order = 3)]
        public string BANKNUM { get; set; }
        /// <summary>
        /// 开户行名称
        /// </summary>
        [XmlElement(Order = 4)]
        public string BANKDESC { get; set; }
        /// <summary>
        /// 用户评级信息
        /// </summary>
        [XmlElement(Order = 5)]
        public CREDITINFO CREDITINFO { get; set; }
    }
    /// <summary>
    /// 评级信息
    /// </summary>
    public class CREDITINFO
    {
        /// <summary>
        /// 信用级别,1-3
        /// </summary>
        [XmlElement(Order = 1)]
        public string CRDLVL { get; set; }
        /// <summary>
        /// 评级机构,1-60
        /// </summary>
        [XmlElement(Order = 2)]
        public string RTGAGNCY { get; set; }
        /// <summary>
        /// 评级到期日 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime RTGDUEDATE { get; set; }
        /// <summary>
        /// 评级到期日 YYYY-MM-DD, 对应<see cref="RTGDUEDATE"/>
        /// </summary>
        [XmlElement("RTGDUEDATE", Order = 3)]
        public string RTGDUEDATEStr
        {
            get
            {
                return this.RTGDUEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RTGDUEDATE = tmp;
                }
            }
        }
    }
}
