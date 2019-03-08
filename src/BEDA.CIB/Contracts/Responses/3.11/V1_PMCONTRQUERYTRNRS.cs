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
    /// 3.11.1.1贵金属账户签约查询响应主体
    /// </summary>
    public class V1_PMCONTRQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.11.1.1贵金属账户签约查询响应主体
        /// </summary>
        public PMCONTRQUERYTRNRS PMCONTRQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.11.1.1贵金属账户签约查询响应主体
    /// </summary>
    public class PMCONTRQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.11.1.1贵金属账户签约查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMCONTRQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.11.1.1贵金属账户签约查询响应内容
    /// </summary>
    public class PMCONTRQUERYTRN_RSBODY
    {
        /// <summary>
        /// 活期账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 客户经理，8位
        /// </summary>
        [XmlElement(Order = 3)]
        public string CUSTMGR { get; set; }
        /// <summary>
        /// 黄金交易编码,10位
        /// </summary>
        [XmlElement(Order = 4)]
        public string TRADECODE { get; set; }
        /// <summary>
        /// 经办人姓名，最长50位
        /// </summary>
        [XmlElement(Order = 5)]
        public string SUBMITORNAME { get; set; }
        /// <summary>
        /// 经办人证件号码，最长20位
        /// </summary>
        [XmlElement(Order = 6)]
        public string SUBMITORIDNO { get; set; }
        /// <summary>
        /// 经办人证件类型，1位
        /// 0 居民身份证或临时身份证 
        /// 1 企业客户营业执照                 
        /// 2 企业代码证                       
        /// 3 企业客户其他有效证件          
        /// 4 军人身份证                       
        /// 5 武警身份证                       
        /// 6 港、澳、台居民有效身份证         
        /// 7 外国护照                         
        /// 8 个人客户其他有效证件             
        /// 9 中国护照
        /// </summary>
        [XmlElement(Order = 7)]
        public string SUBMITORIDTYPE { get; set; }
        /// <summary>
        /// 地址，最长60位
        /// </summary>
        [XmlElement(Order = 8)]
        public string ADDR { get; set; }
        /// <summary>
        /// 证件类型，1位，参见经办人证件类型
        /// </summary>
        [XmlElement(Order = 9)]
        public string IDTYPE { get; set; }
        /// <summary>
        /// 证件号码，最长20位
        /// </summary>
        [XmlElement(Order = 10)]
        public string IDNO { get; set; }
        /// <summary>
        /// 客户名称，最长50位
        /// </summary>
        [XmlElement(Order = 11)]
        public string CUSTNAME { get; set; }
        /// <summary>
        /// 户名简称，最长20位
        /// </summary>
        [XmlElement(Order = 12)]
        public string SHORTNAME { get; set; }
        /// <summary>
        /// 邮政编码，6位
        /// </summary>
        [XmlElement(Order = 13)]
        public string ZIP { get; set; }
        /// <summary>
        /// 电话号码，最长20位
        /// </summary>
        [XmlElement(Order = 14)]
        public string PHONE { get; set; }
        /// <summary>
        /// 手机号码，最长11位
        /// </summary>
        [XmlElement(Order = 15)]
        public string MOBILE { get; set; }
        /// <summary>
        /// Email，最长30位
        /// </summary>
        [XmlElement(Order = 16)]
        public string EMAIL { get; set; }
        /// <summary>
        /// 企业代码，12位
        /// </summary>
        [XmlElement(Order = 17)]
        public string FIRMCODE { get; set; }
        /// <summary>
        /// 法人代表，最长50位
        /// </summary>
        [XmlElement(Order = 18)]
        public string JURIDICALPRSN { get; set; }
        /// <summary>
        /// 质权人标识，1位
        /// </summary>
        [XmlElement(Order = 19)]
        public string IMPAWNEEFLAG { get; set; }
        /// <summary>
        /// 注册资本，decimal(15,2) 即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 20)]
        public decimal REGFUND { get; set; }
        /// <summary>
        /// 客户类型,1位
        /// </summary>
        [XmlElement(Order = 21)]
        public string CUSTTYPE { get; set; }
        /// <summary>
        /// 纳税人识别号，最长20位
        /// </summary>
        [XmlElement(Order = 22)]
        public string TAXPAYERFLAG { get; set; }
        /// <summary>
        /// 是否增值税一般纳税人，Y/N
        /// </summary>
        [XmlElement(Order = 23)]
        public string COMMERTAXPAYER { get; set; }
        /// <summary>
        /// 纳税人地址，最长60位
        /// </summary>
        [XmlElement(Order = 24)]
        public string TAXPAYERADDR { get; set; }
        /// <summary>
        /// 纳税人电话，最长20位
        /// </summary>
        [XmlElement(Order = 25)]
        public string TAXPAYERPHONE { get; set; }
        /// <summary>
        /// 纳税人银行账户，最长30位
        /// </summary>
        [XmlElement(Order = 26)]
        public string TAXPAYERACCT { get; set; }
        /// <summary>
        /// 纳税人银行代码，3位
        /// </summary>
        [XmlElement(Order = 27)]
        public string TAXPAYERBANK { get; set; }
        /// <summary>
        /// 纳税人开户行信息，最长80位
        /// </summary>
        [XmlElement(Order = 28)]
        public string TAXPAYEROPENBANK { get; set; }
        /// <summary>
        /// 开户日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime? OPENDATE { get; set; }
        /// <summary>
        /// 开户日期 YYYY-MM-DD, 对应<see cref="OPENDATE"/>
        /// </summary>
        [XmlElement("OPENDATE", Order = 29)]
        public string OPENDATEStr
        {
            get
            {
                return this.OPENDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.OPENDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPENDATE = tmp;
                }
            }
        }
    }
}
