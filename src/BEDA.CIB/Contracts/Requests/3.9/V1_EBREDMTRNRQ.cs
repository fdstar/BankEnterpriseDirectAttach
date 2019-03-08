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
    /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回请求主体
    /// </summary>
    public class V1_EBREDMTRNRQ : IRequest<V1_EBREDMTRNRS>
    {
        /// <summary>
        /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回请求主体
        /// </summary>
        public EBREDMTRNRQ EBREDMTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回请求主体
    /// </summary>
    public class EBREDMTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBREDMTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回请求内容
    /// </summary>
    public class EBREDMTRN_RQBODY
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
        /// 赎回申请日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime APPDATE { get; set; }
        /// <summary>
        /// 赎回申请日期 YYYY-MM-DD, 对应<see cref="APPDATE"/> 必输
        /// </summary>
        [XmlElement("APPDATE", Order = 5)]
        public string APPDATEStr
        {
            get
            {
                return this.APPDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 赎回申请人账户代号,最大32位	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string APPACCTID { get; set; }
        /// <summary>
        /// 赎回类型,(DT00:回购式贴现赎回,DT01:回购式转贴现赎回)	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string REDMTYPE { get; set; }
        /// <summary>
        /// 赎回利率,7位百分数不含百分号(2位整数,5位小数)	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal INTRSTRATE { get; set; }
        /// <summary>
        /// 票据类型,4位(AC01:银票,AC02:商票)	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 可否转让标识,4位 (EM00:可再转让,EM01:不可再转让)	必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string NEGTBL { get; set; }
        /// <summary>
        /// 清算模式,4位(SM00:线上清算,SM01:线下清算)	必输
        /// </summary>
        [XmlElement(Order = 11)]
        public string LQMODE { get; set; }
        /// <summary>
        /// 原贴入人备注,最大256位	非必输
        /// </summary>
        [XmlElement(Order = 12)]
        public string DECTMEMO { get; set; }
        /// <summary>
        /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<EBREDMTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回请求明细
    /// </summary>
    public class EBREDMTRN_CONTENT
    {
        /// <summary>
        /// 小序号,4位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int INDX { get; set; }
        /// <summary>
        /// 票据号码,30位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 赎回实付金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal REALPAY { get; set; }
    }
}
