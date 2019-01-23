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
    /// 3.8.3理财产品信息查询响应主体
    /// </summary>
    public class V1_FPPRODTRNRS : IResponse
    {
        /// <summary>
        /// 3.8.3理财产品信息查询响应主体
        /// </summary>
        public FPPRODTRNRS FPPRODTRNRS { get; set; }
    }
    /// <summary>
    /// 3.8.3理财产品信息查询响应主体
    /// </summary>
    public class FPPRODTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.8.3理财产品信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FPPRODTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.8.3理财产品信息查询响应内容
    /// </summary>
    public class FPPRODTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.8.3理财产品信息查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<FPPRODTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.8.3理财产品信息查询响应明细
    /// </summary>
    public class FPPRODTRN_CONTENT
    {
        /// <summary>
        /// 产品代码，8位
        /// </summary>
        [XmlElement(Order = 0)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 产品简称，最长50位
        /// </summary>
        [XmlElement(Order = 1)]
        public string PRODNAME { get; set; }
        /// <summary>
        /// 销售币种 2 位
        /// </summary>
        [XmlElement(Order = 2)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 销售对象:1个人(不提供);2公司;3全部;4同业;
        /// </summary>
        [XmlElement(Order = 3)]
        public int TARGET { get; set; }
        /// <summary>
        /// 收益表示方式:1收益率 2 净值
        /// </summary>
        [XmlElement(Order = 4)]
        public int RETURNTYPE { get; set; }
        /// <summary>
        /// 认购开始日期，yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 认购开始日期，yyyy-MM-dd ,对应<see cref="DTSTART"/>
        /// </summary>
        [XmlElement("DTSTART", Order = 5)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTSTART = tmp;
                }
            }
        }
        /// <summary>
        /// 认购结束日期，yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 认购结束日期，yyyy-MM-dd ,对应<see cref="DTEND"/>
        /// </summary>
        [XmlElement("DTEND", Order = 6)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTEND = tmp;
                }
            }
        }
        /// <summary>
        /// 理财起息日，yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime INTRSTEDTSTART { get; set; }
        /// <summary>
        /// 理财起息日，yyyy-MM-dd ,对应<see cref="INTRSTEDTSTART"/>
        /// </summary>
        [XmlElement("INTRSTEDTSTART", Order = 7)]
        public string INTRSTEDTSTARTStr
        {
            get
            {
                return this.INTRSTEDTSTART.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTRSTEDTSTART = tmp;
                }
            }
        }
        /// <summary>
        /// 理财到期日，yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime EXPIREDATE { get; set; }
        /// <summary>
        /// 理财到期日，yyyy-MM-dd ,对应<see cref="EXPIREDATE"/>
        /// </summary>
        [XmlElement("EXPIREDATE", Order = 8)]
        public string EXPIREDATEStr
        {
            get
            {
                return this.EXPIREDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPIREDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 理财兑付日，yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTEXCHANGE { get; set; }
        /// <summary>
        /// 理财兑付日，yyyy-MM-dd ,对应<see cref="DTEXCHANGE"/>
        /// </summary>
        [XmlElement("DTEXCHANGE", Order = 9)]
        public string DTEXCHANGEStr
        {
            get
            {
                return this.DTEXCHANGE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTEXCHANGE = tmp;
                }
            }
        }
        /// <summary>
        /// 参考收益率(净值)  decimal(11,4)，即整数位最长7位，小数位4位
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal REFVALUE { get; set; }
        /// <summary>
        /// 管理费 decimal(15,4)，即整数位最长13位，小数4位
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal MANAGEMENTFEE { get; set; }
        /// <summary>
        /// 认购手续费decimal(11,4)，即整数位最长7位，小数位4位
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal SBSCRFEE { get; set; }
        /// <summary>
        /// 申购手续费decimal(11,4)，即整数位最长7位，小数位4位
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal PURCHFEE { get; set; }
        /// <summary>
        /// 赎回手续费decimal(11,4)，即整数位最长7位，小数位4位
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal REDMFEE { get; set; }
        /// <summary>
        /// 是否可认购 0不可操作 1可操作
        /// </summary>
        [XmlElement(Order = 15)]
        public int SBSCRFLG { get; set; }
        /// <summary>
        /// 是否可申购 0不可操作 1可操作
        /// </summary>
        [XmlElement(Order = 16)]
        public int PURCHFLG { get; set; }
        /// <summary>
        /// 是否可赎回 0不可操作 1可操作
        /// </summary>
        [XmlElement(Order = 17)]
        public int REDMFLG { get; set; }
        /// <summary>
        /// 认购最低金额 decimal(18,2)，即整数位最长16位，小数位2位
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal SBSCRMINAMT { get; set; }
        /// <summary>
        /// 认购递增金额 decimal(18,2)，即整数位最长16位，小数位2位
        /// </summary>
        [XmlElement(Order = 19)]
        public decimal SBSCRINCAMT { get; set; }
        /// <summary>
        /// 申购最低金额decimal(18,2)，即整数位最长16位，小数位2位
        /// </summary>
        [XmlElement(Order = 20)]
        public decimal PURCHMINAMT { get; set; }
        /// <summary>
        /// 申购递增金额 decimal(18,2)，即整数位最长16位，小数位2位
        /// </summary>
        [XmlElement(Order = 21)]
        public decimal PURCHINCAMT { get; set; }
        /// <summary>
        /// 最低持有金额 decimal(18,2)，即整数位最长16位，小数位2位
        /// </summary>
        [XmlElement(Order = 22)]
        public decimal HOLDMINAMT { get; set; }
        /// <summary>
        /// 最高持有金额 decimal(18,2)，即整数位最长16位，小数位2位
        /// </summary>
        [XmlElement(Order = 23)]
        public decimal HOLDMAXAMT { get; set; }
        /// <summary>
        /// 赎回最低金额decimal(18,2)，即整数位最长16位，小数位2位
        /// </summary>
        [XmlElement(Order = 24)]
        public decimal REDMMINAMT { get; set; }
        /// <summary>
        /// 赎回递增金额decimal(18,2)，即整数位最长16位，小数位2位
        /// </summary>
        [XmlElement(Order = 25)]
        public decimal REDMINCAMT { get; set; }
    }
}
