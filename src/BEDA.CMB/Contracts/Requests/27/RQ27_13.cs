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
    /// 27.13.维护/终止划拨关系限额请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_13 : CMBBase<RQINFO>, IRequest<RS27_13>
    {
        /// <summary>
        /// NTALMMNT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTALMMNT";
        /// <summary>
        /// 27.13.维护/终止划拨关系限额请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 27.13.维护/终止划拨关系限额请求内容
        /// </summary>
        public NTALMMNTX1 NTALMMNTX1 { get; set; }
    }
    /// <summary>
    /// 27.13.维护/终止划拨关系限额请求内容
    /// </summary>
    public class NTALMMNTX1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 维护类型	C(1)    M：维护划拨关系限额 D：终止划拨关系限额
        /// </summary>
        public string MNTTYP { get; set; }
        /// <summary>
        /// 原限额生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ORGBEG { get; set; }
        /// <summary>
        /// 原限额生效日期	D, 对应<see cref="ORGBEG"/>
        /// </summary>
        [XmlElement("ORGBEG")]
        public string ORGBEGStr
        {
            get
            {
                return this.ORGBEG.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ORGBEG = tmp;
                }
            }
        }
        /// <summary>
        /// 限额设置位图	C(6)
        /// 若xMntTyp为D，不用输入
        /// 若xMntTyp为M，必输，至少有一位为Y。
        /// 第1位是单笔最大限额
        /// 第2位是日累计限额
        /// 第3位是周期限额一
        /// 第4位是周期限额二
        /// 第5、6位预留。
        /// </summary>
        public string CTLMAP { get; set; }
        /// <summary>
        /// 单笔最大限额	F(17,2) 若xMntTyp为D，不用输入 限额设置位图第1位为Y时必输（大于0），为N时须为0
        /// </summary>
        public decimal? SGNMAX { get; set; }
        /// <summary>
        /// 日累计限额	F(17,2) 若xMntTyp为D，不用输入 限额设置位图第2位为Y时不能为0
        /// </summary>
        public decimal? DAYMAX { get; set; }
        /// <summary>
        /// 限额一周期代码	C(1)   若xMntTyp为D，不用输入  限额设置位图第三位为Y时必输。（年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR1COD { get; set; }
        /// <summary>
        /// 限额一周期累计天数	C(4)   若xMntTyp为D，不用输入  限额设置位图第三位为Y并且限额一周期代码是S的时候不能为0
        /// </summary>
        public string PR1DAY { get; set; }
        /// <summary>
        /// 限额一周期起始日	D   若xMntTyp为D，不用输入
        /// 限额设置位图CTLMAP第3位为Y时必输
        /// 限额设置位图CTLMAP第3位为N时必须为0
        /// 周期代码PR1COD为M-月时取值范围[1, 31]
        /// 周期代码PR1COD为W-周时取值范围[1, 7]
        /// 周期代码PR1COD为T-旬时必须为0
        /// 周期代码PR1COD为S时，要为日期格式.
        /// </summary>
        public string PR1STR { get; set; }
        /// <summary>
        /// 限额一周期限额	F(17,2) 若xMntTyp为D，不用输入 限额设置位图CTLMAP第3位为Y时不能为0;限额设置位图CTLMAP第3位为N时必须为0

        /// </summary>
        public decimal? PR1AMT { get; set; }
        /// <summary>
        /// 限额二周期代码	C(1)  若xMntTyp为D，不用输入  限额设置位图第四位为Y时必输。（年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR2COD { get; set; }
        /// <summary>
        /// 限额二周期累计天数	C(4)  若xMntTyp为D，不用输入   限额设置位图CTLMAP第4位为Y并且PR2COD值为S时不能为0
        /// </summary>
        public string PR2DAY { get; set; }
        /// <summary>
        /// 限额二周期起始日	D   若xMntTyp为D，不用输入  
        /// 限额设置位图第4位为Y时必输
        /// 限额设置位图第4位为N时必须为0
        /// 周期代码PR2COD为M-月时取值范围[1, 31]
        /// 周期代码PR2COD为W-周时取值范围[1, 7]
        /// 周期代码PR2COD为T-旬时必须为0。
        /// </summary>
        public string PR2STR { get; set; }
        /// <summary>
        /// 限额二周期限额	F(17,2) 若xMntTyp为D，不用输入   限额设置位图CTLMAP第4位为Y时不能为0 限额设置位图CTLMAP第4位为N时必须为0
        /// </summary>
        public decimal? PR2AMT { get; set; }
        /// <summary>
        /// 限额生效日期	D   若xMntTyp为D，不用输入 MNTTYP为M时，必输
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 限额生效日期	D, 对应<see cref="BEGDAT"/>
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
        /// 限额失效日期	D   若xMntTyp为D，不用输入 MNTTYP为M时，必输
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 限额失效日期	D, 对应<see cref="ENDDAT"/>
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
        /// 更新记录版本号	C(4)
        /// </summary>
        public string RCDVER { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
