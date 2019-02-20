using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
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
    /// 3.9.2.1电子商业汇票出票申请/出票信息登记请求主体
    /// </summary>
    public class V1_EBDRAWTRNRQ : IRequest<V1_EBDRAWTRNRS>
    {
        /// <summary>
        /// 3.9.2.1电子商业汇票出票申请/出票信息登记请求主体
        /// </summary>
        public EBDRAWTRNRQ EBDRAWTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.2.1电子商业汇票出票申请/出票信息登记请求主体
    /// </summary>
    public class EBDRAWTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.2.1电子商业汇票出票申请/出票信息登记请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBDRAWTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.1电子商业汇票出票申请/出票信息登记请求内容
    /// </summary>
    public class EBDRAWTRN_RQBODY
    {
        /// <summary>
        /// 票据总笔数,8位整数	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT
        {
            get
            {
                return this.List?.Count ?? 0;
            }
            set { }
        }
        /// <summary>
        /// 票据总金额, 17位(15整数位,2小数位) 	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT
        {
            get
            {
                return this.List?.Sum(c => c.BILLAMT) ?? 0;
            }
            set { }
        }
        /// <summary>
        /// 交易类型,2位  必输
        /// 01(出票登记)
        /// 02(出票, 保证)
        /// 03(出票, 承兑)
        /// 04(出票, 保证, 承兑)
        /// 05(出票, 承兑, 提示收票)
        /// 06(出票, 保证, 自动提示承兑, 自动提示收票)
        /// </summary>
        [XmlElement(Order = 5)]
        public string TYPE { get; set; }
        /// <summary>
        /// 票据类型,4位(AC01:银票,AC02:商票)	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 出票申请账户代号,最大32位	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string DRAWACCTID { get; set; }
        /// <summary>
        /// 出票人评级信息	非必输                              
        /// </summary>
        [XmlElement(Order = 8)]
        public CREDITINFO CRDINFO { get; set; }
        /// <summary>
        /// 3.9.2.1电子商业汇票出票申请/出票信息登记请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<EBDRAWTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.2.1电子商业汇票出票申请/出票信息登记请求明细
    /// </summary>
    public class EBDRAWTRN_CONTENT
    {
        /// <summary>
        /// 小序号,4位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public int INDX { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 出票日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DRAWDATE { get; set; }
        /// <summary>
        /// 出票日期，格式yyyy-MM-dd ,对应<see cref="DRAWDATE"/> 必输
        /// </summary>
        [XmlElement("DRAWDATE", Order = 3)]
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
        /// 票据到期日 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 票据到期日，格式yyyy-MM-dd ,对应<see cref="DUEDATE"/> 必输
        /// </summary>
        [XmlElement("DUEDATE", Order = 4)]
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
        /// 转让标识 4位(EM00:可再转让,EM01:不可再转让) 必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string NEGTBL { get; set; }
        /// <summary>
        /// 收款账户代号是否兴业账户代号,1位(Y:是,N:否)	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string ISCIB { get; set; }
        /// <summary>
        /// 收款账户信息	必输  注意不传递 BANKDESC
        /// </summary>
        [XmlElement(Order = 7)]
        public CORRELATEACCT PAYEEACCT { get; set; }
        /// <summary>
        /// 承兑人账户信息	必输  注意不传递 BANKDESC
        /// </summary>
        [XmlElement(Order = 8)]
        public CORRELATEACCT ACACCT { get; set; }
        /// <summary>
        /// 到期无条件支付委托,4位只能是CC00	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string ENTRSPAY { get; set; }
        /// <summary>
        /// 1、出票保证人账户代号是否兴业账户代号,1位(Y:是,N:否) 
        /// 2、当交易类型选择02、04、06时，保证人信息必输。其他不输。	非必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string DGISCIB { get; set; }
        /// <summary>
        /// 出票保证人账户信息	非必输  注意不传递 BANKDESC
        /// </summary>
        [XmlElement(Order = 11)]
        public CORRELATEACCT DGACCTINFO { get; set; }
        /// <summary>
        /// 交易合同号,最大30位	非必输
        /// </summary>
        [XmlElement(Order = 12)]
        public string CONTRACTID { get; set; }
        /// <summary>
        /// 发票号码,最大30位	非必输
        /// </summary>
        [XmlElement(Order = 13)]
        public string INVCNO { get; set; }
        /// <summary>
        /// 允许承兑金额,17位(15整数位,2小数位)(暂不支持部分承兑)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? ALLOWACAMT { get; set; }
        /// <summary>
        /// 允许承兑金额,17位(15整数位,2小数位)(暂不支持部分承兑) 对应<see cref="ALLOWACAMT"/>	非必输
        /// </summary>
        [XmlElement("ALLOWACAMT", Order = 14)]
        public string ALLOWACAMTStr
        {
            get
            {
                return this.ALLOWACAMT?.ToString();
            }
            set
            {
                this.ALLOWACAMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 信息登记备注,最大256位	非必输
        /// </summary>
        [XmlElement(Order = 15)]
        public string DRAWMEMO { get; set; }
    }
}
