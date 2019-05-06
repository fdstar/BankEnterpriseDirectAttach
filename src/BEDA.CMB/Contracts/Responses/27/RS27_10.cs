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
    /// 27.10.查询内部户限额响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTILMQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTILMQRY";
        /// <summary>
        /// 27.10.查询内部户限额响应集合
        /// </summary>
        [XmlElement("NTILMQRYZ1")]
        public List<NTILMQRYZ1> List { get; set; }
    }
    /// <summary>
    /// 27.10.查询内部户限额响应内容
    /// </summary>
    public class NTILMQRYZ1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 上级账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 账户名称	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 内部户编号	C(10)
        /// </summary>
        public string INANBR { get; set; }
        /// <summary>
        /// 内部户名称	Z(100)
        /// </summary>
        public string INANAM { get; set; }
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 限额设置位图	C(6)
        /// 第一位是单笔最大限额；（不使用，为N）
        /// 第二位是日累计限额
        /// 第三位是周期限额一
        /// 第四位是周期限额二
        /// </summary>
        public string CTLMAP { get; set; }
        /// <summary>
        /// 单笔最大限额	F(17,2)
        /// </summary>
        public decimal? SGNMAX { get; set; }
        /// <summary>
        /// 日累计限额	F(17,2)
        /// </summary>
        public decimal? DAYMAX { get; set; }
        /// <summary>
        /// 日已用限额	F(17,2)
        /// </summary>
        public decimal? DAYUSE { get; set; }
        /// <summary>
        /// 日可用限额	F(17,2)
        /// </summary>
        public decimal? DAYOBL { get; set; }
        /// <summary>
        /// 限额一周期代码	C(1)    （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR1COD { get; set; }
        /// <summary>
        /// 限额一周期累计天数	C(4)
        /// </summary>
        public string PR1DAY { get; set; }
        /// <summary>
        /// 限额一周期起始日	D
        /// </summary>
        public string PR1STR { get; set; }
        /// <summary>
        /// 限额一周期限额	F(17,2)
        /// </summary>
        public decimal? PR1AMT { get; set; }
        /// <summary>
        /// 限额一本期已用限额	F(17,2)
        /// </summary>
        public decimal? PR1PAT { get; set; }
        /// <summary>
        /// 限额一本周期起始日	D
        /// </summary>
        public string PR1PSR { get; set; }
        /// <summary>
        /// 限额一本周期结束日	D
        /// </summary>
        public string PR1PED { get; set; }
        /// <summary>
        /// 限额一本期可用余额	F(17,2)
        /// </summary>
        public decimal? PR1OBL { get; set; }
        /// <summary>
        /// 限额二周期代码	C(1)（年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR2COD { get; set; }
        /// <summary>
        /// 限额二周期累计天数	C(4)
        /// </summary>
        public string PR2DAY { get; set; }
        /// <summary>
        /// 限额二周期起始日	D
        /// </summary>
        public string PR2STR { get; set; }
        /// <summary>
        /// 限额二周期限额
        /// </summary>
        public decimal? PR2AMT { get; set; }
        /// <summary>
        /// 限额二本期已用限额	F(17,2)	
        /// </summary>
        public decimal? PR2PAT { get; set; }
        /// <summary>
        /// 限额二本周期起始日	D
        /// </summary>
        public string PR2PSR { get; set; }
        /// <summary>
        /// 限额二本周期结束日	D
        /// </summary>
        public string PR2PED { get; set; }
        /// <summary>
        /// 限额二本期可用余额	F(17,2)
        /// </summary>
        public decimal? PR2OBL { get; set; }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 失效日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 更新记录版本号	C(4)
        /// </summary>
        public string RCDVER { get; set; }
    }
}
