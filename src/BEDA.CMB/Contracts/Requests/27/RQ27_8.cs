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
    /// 27.8.内部户限额单笔设置请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_8 : CMBBase<RQINFO>, IRequest<RS27_8>
    {
        /// <summary>
        /// NTILMADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTILMADD";
        /// <summary>
        /// 27.8.内部户限额单笔设置请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 27.8.内部户限额单笔设置请求内容
        /// </summary>
        public NTILMADDX1 NTILMADDX1 { get; set; }
    }
    /// <summary>
    /// 27.8.内部户限额单笔设置请求内容
    /// </summary>
    public class NTILMADDX1
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
        /// 内部户编号	C(10)
        /// </summary>
        public string INANBR { get; set; }
        /// <summary>
        /// 限额设置位图	C(6)
        /// 必须选择一种限额模式
        /// 第一位是单笔最大限额；（不使用，为N）
        /// 第二位是日累计限额
        /// 第三位是周期限额一
        /// 第四位是周期限额二
        /// </summary>
        public string CTLMAP { get; set; }
        /// <summary>
        /// 单笔最大限额	F(17,2) 限额设置位图第二位为Y时必输
        /// </summary>
        public decimal? SGNMAX { get; set; }
        /// <summary>
        /// 日累计限额	F(17,2) 限额设置位图第二位为Y时必输
        /// </summary>
        public decimal? DAYMAX { get; set; }
        /// <summary>
        /// 限额一周期代码	C(1)    限额设置位图第三位为Y时必输。（年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR1COD { get; set; }
        /// <summary>
        /// 限额一周期累计天数	C(4)    限额设置位图第三位为Y并且限额一周期代码是S的时候必输
        /// </summary>
        public string PR1DAY { get; set; }
        /// <summary>
        /// 限额一周期起始日	D
        /// 限额设置位图第三位为Y时必输，周期代码为T-旬时，周期起始日为0.
        /// xPr1Cod为W或M或S时不能为0.
        /// xPr1Cod为M时，取值范围[1, 31]. 
        /// xPr1Cod为W时，取值范围[1, 7].
        /// xPr1Cod为S时，要为日期格式.
        /// </summary>
        public string PR1STR { get; set; }
        /// <summary>
        /// 限额一周期限额	F(17,2) 限额设置位图第三位为Y时必输
        /// </summary>
        public decimal? PR1AMT { get; set; }
        /// <summary>
        /// 限额二周期代码	C(1)    限额设置位图第四位为Y时必输。（年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR2COD { get; set; }
        /// <summary>
        /// 限额二周期累计天数	C(4)    限额设置位图第四位为Y并且限额二周期代码是S的时候必输
        /// </summary>
        public string PR2DAY { get; set; }
        /// <summary>
        /// 限额二周期起始日	D
        /// 限额设置位图第四位为Y时必输，周期代码为T-旬时，周期起始日为0.为N时须为0.
        /// xPr2Cod为W或M或S时不能为0.
        /// xPr2Cod为M时，取值范围[1, 31].
        /// xPr2Cod为W时，取值范围[1, 7].
        /// xPr2Cod为S时，要为日期格式.
        /// </summary>
        public string PR2STR { get; set; }
        /// <summary>
        /// 限额二周期限额	F(17,2) 限额设置位图第四位为Y时必输
        /// </summary>
        public decimal? PR2AMT { get; set; }
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
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
