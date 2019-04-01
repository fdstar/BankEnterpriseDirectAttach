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
    /// 13.4.查询支付限额协议响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS13_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTQRYLMT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQRYLMT";
        /// <summary>
        /// 13.4.查询支付限额协议响应集合
        /// </summary>
        [XmlElement("NTQRYLMTZ")]
        public List<NTQRYLMTZ> List { get; set; }
    }
    /// <summary>
    /// 13.4.查询支付限额协议响应内容
    /// </summary>
    public class NTQRYLMTZ
    {
        /// <summary>
        /// 子公司账号	C(35)
        /// </summary>
        public string SUBACC { get; set; }
        /// <summary>
        /// 单笔最大限额生效标记	C(1)	Y:有效定义,N未生效设置  默认未生效
        /// </summary>
        public string BITMA1 { get; set; }
        /// <summary>
        /// 日累计限额生效标记	C(1)	Y:有效定义,N未生效设置  默认未生效
        /// </summary>
        public string BITMA2 { get; set; }
        /// <summary>
        /// 周期性限额设置一生效标记	C(1)	Y:有效定义,N未生效设置   默认未生效
        /// </summary>
        public string BITMA3 { get; set; }
        /// <summary>
        /// 周期性限额设置二生效标记	C(1)	Y:有效定义,N未生效设置   默认未生效
        /// </summary>
        public string BITMA4 { get; set; }
        /// <summary>
        /// 单笔最大限额	M   BITMA1为Y时必输
        /// </summary>
        public decimal? SGLLMT { get; set; }
        /// <summary>
        /// 日累计限额	M   BITMA2为Y时必输
        /// </summary>
        public decimal? DAYLMT { get; set; }
        /// <summary>
        /// 日累计可用余额	M
        /// </summary>
        public decimal? DAYOBL { get; set; }
        /// <summary>
        /// 限额一周期代码	C(1)    Y:年；M:月；W:周；S:指定日期段；T:旬
        /// </summary>
        public string PERCD1 { get; set; }
        /// <summary>
        /// 限额一周期累计天数	N(4)    当周期代码为S时生效，指从周期起始日开始，到若干天后结束的区间天数
        /// </summary>
        public string DAYNB1 { get; set; }
        /// <summary>
        /// 限额一周期起始日 	C(8)    备注1
        /// </summary>
        public string STRDY1 { get; set; }
        /// <summary>
        /// 限额一周期限额	M   周期内累计限额值，BITMA3为Y时必输
        /// </summary>
        public decimal? PERLM1 { get; set; }
        /// <summary>
        /// 限额一本期可用余额	M
        /// </summary>
        public decimal? USBLM1 { get; set; }
        /// <summary>
        /// 限额一本周期起始日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PERSD1 { get; set; }
        /// <summary>
        /// 限额一本周期起始日	D, 对应<see cref="PERSD1"/>
        /// </summary>
        [XmlElement("PERSD1")]
        public string PERSD1Str
        {
            get
            {
                return this.PERSD1?.ToString("yyyyMMdd");
            }
            set
            {
                this.PERSD1 = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PERSD1 = tmp;
                }
            }
        }
        /// <summary>
        /// 限额一本周期结束日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PERED1 { get; set; }
        /// <summary>
        /// 限额一本周期结束日	D, 对应<see cref="PERED1"/>
        /// </summary>
        [XmlElement("PERED1")]
        public string PERED1Str
        {
            get
            {
                return this.PERED1?.ToString("yyyyMMdd");
            }
            set
            {
                this.PERED1 = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PERED1 = tmp;
                }
            }
        }
        /// <summary>
        /// 限额二周期代码	C(1)    同限额一所述
        /// </summary>
        public string PERCD2 { get; set; }
        /// <summary>
        /// 限额二周期累计天数	N(4)    同限额一所述
        /// </summary>
        public string DAYNB2 { get; set; }
        /// <summary>
        /// 限额二周期起始日	C(8)    同限额一所述D
        /// </summary>
        public string STRDY2 { get; set; }
        /// <summary>
        /// 限额二周期限额	M   同限额一所述，BITMA4为Y时必输
        /// </summary>
        public decimal? PERLM2 { get; set; }
        /// <summary>
        /// 限额二本期可用余额	M
        /// </summary>
        public decimal? USBLM2 { get; set; }
        /// <summary>
        /// 限额二本周期起始日 	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PERSD2 { get; set; }
        /// <summary>
        /// 限额二本周期起始日 	D, 对应<see cref="PERSD2"/>
        /// </summary>
        [XmlElement("PERSD2")]
        public string PERSD2Str
        {
            get
            {
                return this.PERSD2?.ToString("yyyyMMdd");
            }
            set
            {
                this.PERSD2 = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PERSD2 = tmp;
                }
            }
        }
        /// <summary>
        /// 限额二本周期结束日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PERED2 { get; set; }
        /// <summary>
        /// 限额二本周期结束日	D, 对应<see cref="PERED2"/>
        /// </summary>
        [XmlElement("PERED2")]
        public string PERED2Str
        {
            get
            {
                return this.PERED2?.ToString("yyyyMMdd");
            }
            set
            {
                this.PERED2 = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PERED2 = tmp;
                }
            }
        }/// <summary>
         /// 协议生效日期	D   协议生效日期(含当天)
         /// </summary>
        [XmlIgnore]
        public DateTime PTCSTD { get; set; }
        /// <summary>
        /// 协议生效日期	D, 对应<see cref="PTCSTD"/>
        /// </summary>
        [XmlElement("PTCSTD")]
        public string PTCSTDStr
        {
            get
            {
                return this.PTCSTD.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PTCSTD = tmp;
                }
            }
        }
        /// <summary>
        /// 协议失效日期	D   必须大于等于协议生效日期(含当天)
        /// </summary>
        [XmlIgnore]
        public DateTime PTCEDD { get; set; }
        /// <summary>
        /// 协议失效日期	D, 对应<see cref="PTCEDD"/>
        /// </summary>
        [XmlElement("PTCEDD")]
        public string PTCEDDStr
        {
            get
            {
                return this.PTCEDD.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PTCEDD = tmp;
                }
            }
        }
    }
}
