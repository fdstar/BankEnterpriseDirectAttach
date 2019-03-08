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
    /// 3.9.3.21电子商业汇票票据池托收登记簿响应主体
    /// </summary>
    public class V1_EBPCOLLECTIONREGISTERTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.21电子商业汇票票据池托收登记簿响应主体
        /// </summary>
        public EBPCOLLECTIONREGISTERTRNRS EBPCOLLECTIONREGISTERTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.21电子商业汇票票据池托收登记簿响应主体
    /// </summary>
    public class EBPCOLLECTIONREGISTERTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.21电子商业汇票票据池托收登记簿响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPCOLLECTIONREGISTERTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.21电子商业汇票票据池托收登记簿响应内容
    /// </summary>
    public class EBPCOLLECTIONREGISTERTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 票据总笔数	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT { get; set; }
        /// <summary>
        /// 本次查询总金额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT { get; set; }
        /// <summary>
        /// 3.9.3.21电子商业汇票票据池托收登记簿响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<EBPCOLLECTIONREGISTERTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.3.21电子商业汇票票据池托收登记簿响应内容
    /// </summary>
    public class EBPCOLLECTIONREGISTERTRN_CONTENT
    {
        /// <summary>
        /// 客户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string CUSTNAME { get; set; }
        /// <summary>
        /// 入池方式 	必回
        /// 01-托管   02-质押
        /// 托管转质押等同于质押，质押转托管等同于托管。 
        /// </summary>
        [XmlElement(Order = 4)]
        public string INPOOLTYPE { get; set; }
        /// <summary>
        /// 票据号码，16位	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票面金额,(18,2)	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 票据介质，1-纸票  2-电票	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string BILLMEDIUM { get; set; }
        /// <summary>
        /// 票据类型，AC01-银承 AC02-商承	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime OUTDATE { get; set; }
        /// <summary>
        /// 出票日，格式yyyy-MM-dd ,对应<see cref="OUTDATE"/> 必回
        /// </summary>
        [XmlElement("OUTDATE", Order = 9)]
        public string OUTDATEStr
        {
            get
            {
                return this.OUTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OUTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 到期日，格式yyyy-MM-dd ,对应<see cref="DUEDATE"/> 必回
        /// </summary>
        [XmlElement("DUEDATE", Order = 10)]
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
        /// 出票人名称	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string DRAWERNAME { get; set; }
        /// <summary>
        /// 出票人账号	必回
        /// </summary>
        [XmlElement(Order = 12)]
        public string DRAWERACCTNO { get; set; }
        /// <summary>
        /// 收款人名称	必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string PAYEENAME { get; set; }
        /// <summary>
        /// 收款人账号	非必回
        /// </summary>
        [XmlElement(Order = 15)]
        public string PAYEEACCTNO { get; set; }
        /// <summary>
        /// 收款人开户行名称	非必回
        /// </summary>
        [XmlElement(Order = 16)]
        public string PAYEEBANKNAME { get; set; }
        /// <summary>
        /// 收款人开户行行号	非必回
        /// </summary>
        [XmlElement(Order = 17)]
        public string PAYEEBANKCODE { get; set; }
        /// <summary>
        /// 承兑银行/企业	非必回
        /// </summary>
        [XmlElement(Order = 18)]
        public string ACCEPTBANK { get; set; }
        /// <summary>
        /// 付款行名称	必回
        /// </summary>
        [XmlElement(Order = 20)]
        public string DRAWERBANKNAME { get; set; }
        /// <summary>
        /// 付款行行号	必回
        /// </summary>
        [XmlElement(Order = 21)]
        public string DRAWERBANKCODE { get; set; }
        /// <summary>
        /// 托收日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime COLLECTIONDATE { get; set; }
        /// <summary>
        /// 托收日期，格式yyyy-MM-dd ,对应<see cref="COLLECTIONDATE"/> 必回
        /// </summary>
        [XmlElement("COLLECTIONDATE", Order = 23)]
        public string COLLECTIONDATEStr
        {
            get
            {
                return this.COLLECTIONDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.COLLECTIONDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 托收状态 必回
        /// 01-托收清单已录入  02-托收在途 03-托收已回款  04-拒付退票 
        /// </summary>
        [XmlElement(Order = 24)]
        public string COLLECTIONSTATUS { get; set; }
        /// <summary>
        /// 归属机构号	必回
        /// </summary>
        [XmlElement(Order = 25)]
        public string BELONGORGNO { get; set; }
        /// <summary>
        /// 归属机构名称	必回
        /// </summary>
        [XmlElement(Order = 26)]
        public string BELONGORGNAME { get; set; }
        /// <summary>
        /// 回款日期 YYYY-MM-DD 非必回
        /// </summary>
        [XmlIgnore]
        public DateTime? BACKDATE { get; set; }
        /// <summary>
        /// 回款日期，格式yyyy-MM-dd ,对应<see cref="BACKDATE"/> 非必回
        /// </summary>
        [XmlElement("BACKDATE", Order = 27)]
        public string BACKDATEStr
        {
            get
            {
                return this.BACKDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.BACKDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BACKDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 拒付日期 YYYY-MM-DD 非必回
        /// </summary>
        [XmlIgnore]
        public DateTime? REFUSEDATE { get; set; }
        /// <summary>
        /// 拒付日期，格式yyyy-MM-dd ,对应<see cref="REFUSEDATE"/> 非必回
        /// </summary>
        [XmlElement("REFUSEDATE", Order = 28)]
        public string REFUSEDATEStr
        {
            get
            {
                return this.REFUSEDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.REFUSEDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.REFUSEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 拒付原因	非必回
        /// </summary>
        [XmlElement(Order = 29)]
        public string REFUSEREASON { get; set; }
    }
}
