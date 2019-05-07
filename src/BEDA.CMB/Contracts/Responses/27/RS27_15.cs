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
    /// 27.15.多级现金池设置详情查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_15 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTLINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLINF";
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTALMADDZ1 NTALMADDZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTALMMNTZ1 NTALMMNTZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTFDUADDZ2 NTFDUADDZ2 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTFDUMNTZ1 NTFDUMNTZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTFDDADDZ1 NTFDDADDZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTFDDMNTZ1 NTFDDMNTZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTTDUADDZ1 NTTDUADDZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTTDUMNTZ1 NTTDUMNTZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTTDDADDZ1 NTTDDADDZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTTDDMNTZ1 NTTDDMNTZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTILMADDZ1 NTILMADDZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTILMMNTZ1 NTILMMNTZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTINAADDZ2 NTINAADDZ2 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTINADLTZ1 NTINADLTZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTINAMNTZ1 NTINAMNTZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTOPRINTZ2 NTOPRINTZ2 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTMTLRLTZ2 NTMTLRLTZ2 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTMITADDX1 NTMITADDX1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTMTLRLDZ1 NTMTLRLDZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTMTLRLCZ1 NTMTLRLCZ1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTMITMNTX1 NTMITMNTX1 { get; set; }
        /// <summary>
        /// 27.15.多级现金池设置详情查询响应内容
        /// </summary>
        public NTMTLINFZ1 NTMTLINFZ1 { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTALMADDZ1
    {
        /// <summary>
        /// 分行号           	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级账号         	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级账号名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 限额设置位图     	C(6)
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
        /// 限额一周期代码	C(1)   （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR1COD { get; set; }
        /// <summary>
        /// 限额一周期累计天数	C(4)
        /// </summary>
        public string PR1DAY { get; set; }
        /// <summary>
        /// 限额一周期起始日	D
        /// 限额设置位图第4位为N时必须为0
        /// 周期代码PR2COD为M-月时取值范围[1, 31]
        /// 周期代码PR2COD为W-周时取值范围[1, 7]
        /// 周期代码PR2COD为T-旬时必须为0。
        /// </summary>
        public string PR1STR { get; set; }
        /// <summary>
        /// 限额一周期限额	F(17,2)
        /// </summary>
        public decimal? PR1AMT { get; set; }
        /// <summary>
        /// 限额二周期代码	C(1)  （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR2COD { get; set; }
        /// <summary>
        /// 限额二周期累计天数	C(4)
        /// </summary>
        public string PR2DAY { get; set; }
        /// <summary>
        /// 限额二周期起始日	D
        /// 限额设置位图第4位为N时必须为0
        /// 周期代码PR2COD为M-月时取值范围[1, 31]
        /// 周期代码PR2COD为W-周时取值范围[1, 7]
        /// 周期代码PR2COD为T-旬时必须为0。
        /// </summary>
        public string PR2STR { get; set; }
        /// <summary>
        /// 限额二周期限额	F(17,2)
        /// </summary>
        public decimal? PR2AMT { get; set; }
        /// <summary>
        /// 限额生效日期	D
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
        /// 限额失效日期	D
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
        /// 业务参考号       	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTALMMNTZ1
    {
        /// <summary>
        /// 分行号           	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级账号         	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级账号名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 维护类型         	C(1)
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
        /// 限额设置位图     	C(6)
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
        /// 限额一周期代码	C(1)   （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR1COD { get; set; }
        /// <summary>
        /// 限额一周期累计天数	C(4)
        /// </summary>
        public string PR1DAY { get; set; }
        /// <summary>
        /// 限额一周期起始日	D
        /// 限额设置位图第4位为N时必须为0
        /// 周期代码PR2COD为M-月时取值范围[1, 31]
        /// 周期代码PR2COD为W-周时取值范围[1, 7]
        /// 周期代码PR2COD为T-旬时必须为0。
        /// </summary>
        public string PR1STR { get; set; }
        /// <summary>
        /// 限额一周期限额	F(17,2)
        /// </summary>
        public decimal? PR1AMT { get; set; }
        /// <summary>
        /// 限额二周期代码	C(1)  （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR2COD { get; set; }
        /// <summary>
        /// 限额二周期累计天数	C(4)
        /// </summary>
        public string PR2DAY { get; set; }
        /// <summary>
        /// 限额二周期起始日	D
        /// 限额设置位图第4位为N时必须为0
        /// 周期代码PR2COD为M-月时取值范围[1, 31]
        /// 周期代码PR2COD为W-周时取值范围[1, 7]
        /// 周期代码PR2COD为T-旬时必须为0。
        /// </summary>
        public string PR2STR { get; set; }
        /// <summary>
        /// 限额二周期限额	F(17,2)
        /// </summary>
        public decimal? PR2AMT { get; set; }
        /// <summary>
        /// 限额生效日期	D
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
        /// 限额失效日期	D
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
        /// 更新记录版本号   	C(4)
        /// </summary>
        public string RCDVER { get; set; }
        /// <summary>
        /// 业务参考号       	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTFDUADDZ2
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 分行号         	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 对方户口号	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 母户下拨资金处理方	C(1)    1实时上划回母户  2留存于子户不上划
        /// </summary>
        public string MDFMOD { get; set; }
        /// <summary>
        /// 冻结转账标志	C(1)    N母户冻结不上划 Y母户冻结上划
        /// </summary>
        public string FRZTAG { get; set; }
        /// <summary>
        /// 回单打印模式	C(1)
        /// 1 默认       
        /// 2 打印付款回单
        /// 3 打印收款回单
        /// 4 不打印回单 
        /// </summary>
        public string PRTMOD { get; set; }
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
        /// 业务参考号     	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 触发金额	M
        /// </summary>
        public decimal ACTAMT { get; set; }
        /// <summary>
        /// 上划模式	C(1)    1全额上划；2取整上划
        /// </summary>
        public string BTRMOD { get; set; }
        /// <summary>
        /// 划拨单元	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 多级联动上划层级	C(2)
        /// </summary>
        public string FDULEV { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string CSTREM { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTFDUMNTZ1
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 分行号     	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 对方户口号	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 维护类型   	C(1)
        /// </summary>
        public string MNTTYP { get; set; }
        /// <summary>
        /// 冻结转账标志	C(1)    N母户冻结不上划 Y母户冻结上划
        /// </summary>
        public string FRZTAG { get; set; }
        /// <summary>
        /// 回单打印模式	C(1)
        /// 1 默认       
        /// 2 打印付款回单
        /// 3 打印收款回单
        /// 4 不打印回单 
        /// </summary>
        public string PRTMOD { get; set; }
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
        /// 母户下拨资金处理方	C(1)    1实时上划回母户  2留存于子户不上划
        /// </summary>
        public string MDFMOD { get; set; }
        /// <summary>
        /// 触发金额	M
        /// </summary>
        public decimal ACTAMT { get; set; }
        /// <summary>
        /// 上划模式	C(1)    1全额上划；2取整上划
        /// </summary>
        public string BTRMOD { get; set; }
        /// <summary>
        /// 划拨单元	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 多级联动上划层级	C(2)
        /// </summary>
        public string FDULEV { get; set; }
        /// <summary>
        /// 暂停类型        	C(1)
        /// </summary>
        public string SSPTYP { get; set; }
        /// <summary>
        /// 协议临时暂停开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SPDSDT { get; set; }
        /// <summary>
        /// 协议临时暂停开始日期	D, 对应<see cref="SPDSDT"/>
        /// </summary>
        [XmlElement("SPDSDT")]
        public string SPDSDTStr
        {
            get
            {
                return this.SPDSDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.SPDSDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SPDSDT = tmp;
                }
            }
        }
        /// <summary>
        /// 协议临时暂停终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SPDEDT { get; set; }
        /// <summary>
        /// 协议临时暂停终止日期	D, 对应<see cref="SPDEDT"/>
        /// </summary>
        [XmlElement("SPDEDT")]
        public string SPDEDTStr
        {
            get
            {
                return this.SPDEDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.SPDEDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SPDEDT = tmp;
                }
            }
        }
        /// <summary>
        /// 备注           	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 版本号         	C(4)
        /// </summary>
        public string RCDVER { get; set; }
        /// <summary>
        /// 业务参考号 	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTFDDADDZ1
    {
        /// <summary>
        /// 产品编号    	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 分行号           	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号      	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 对方户口号  	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 额度限制类型	C(1)
        /// 1无限制
        /// 2头寸余额限制
        /// 3内部户余额限制
        /// 4头寸户余额和内部户余额同时控制
        /// </summary>
        public string LMTTYP { get; set; }
        /// <summary>
        /// 单笔转账限额	M
        /// </summary>
        public decimal SCSLMT { get; set; }
        /// <summary>
        /// 渠道限制类型	C(1)
        /// </summary>
        public string CHNLTP { get; set; }
        /// <summary>
        /// 回单打印模式	C(1)
        /// 1默认
        /// 2打印付款回单
        /// 3打印收款回单
        /// 4不打印回单
        /// </summary>
        public string PRTMOD { get; set; }
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
        /// 补足模式       	C(1) 
        /// </summary>
        public string BTDMOD { get; set; }
        /// <summary>
        /// 额度使用优先级 	C(1)    1、子户余额优先；2、母户余额下拨
        /// </summary>
        public string AMTPRI { get; set; }
        /// <summary>
        /// 内部下拨限额标志	C(1)    	Y：限额；N：不限额
        /// </summary>
        public string IDLTAG { get; set; }
        /// <summary>
        /// 限额设置位图     	C(6)
        /// </summary>
        public string CTLMAP { get; set; }
        /// <summary>
        /// 日累计限额	F(17,2)
        /// </summary>
        public decimal? DAYMAX { get; set; }
        /// <summary>
        /// 限额一周期代码	C(1)   （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR1COD { get; set; }
        /// <summary>
        /// 限额一周期累计天数	C(4)
        /// </summary>
        public string PR1DAY { get; set; }
        /// <summary>
        /// 限额一周期起始日	D
        /// 限额设置位图第4位为N时必须为0
        /// 周期代码PR2COD为M-月时取值范围[1, 31]
        /// 周期代码PR2COD为W-周时取值范围[1, 7]
        /// 周期代码PR2COD为T-旬时必须为0。
        /// </summary>
        public string PR1STR { get; set; }
        /// <summary>
        /// 限额一周期限额	F(17,2)
        /// </summary>
        public decimal? PR1AMT { get; set; }
        /// <summary>
        /// 限额二周期代码	C(1)  （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR2COD { get; set; }
        /// <summary>
        /// 限额二周期累计天数	C(4)
        /// </summary>
        public string PR2DAY { get; set; }
        /// <summary>
        /// 限额二周期起始日	D
        /// 限额设置位图第4位为N时必须为0
        /// 周期代码PR2COD为M-月时取值范围[1, 31]
        /// 周期代码PR2COD为W-周时取值范围[1, 7]
        /// 周期代码PR2COD为T-旬时必须为0。
        /// </summary>
        public string PR2STR { get; set; }
        /// <summary>
        /// 限额二周期限额	F(17,2)
        /// </summary>
        public decimal? PR2AMT { get; set; }
        /// <summary>
        /// 多级联动下拨层级 	C(2)
        /// </summary>
        public string FDDLEV { get; set; }
        /// <summary>
        /// 划转比例         	C(3)
        /// </summary>
        public string TRFRAT { get; set; }
        /// <summary>
        /// 备注	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 业务参考号       	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTFDDMNTZ1
    {
        /// <summary>
        /// 产品编号    	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 分行号           	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号      	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 对方户口号  	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 维护类型    	C(1)
        /// A恢复
        /// B暂停
        /// C维护协议要素
        /// D终止
        /// </summary>
        public string MNTTYP { get; set; }
        /// <summary>
        /// 额度限制类型	C(1)
        /// 1无限制
        /// 2头寸余额限制
        /// 3内部户余额限制
        /// 4头寸户余额和内部户余额同时控制
        /// </summary>
        public string LMTTYP { get; set; }
        /// <summary>
        /// 单笔转账限额	M
        /// </summary>
        public decimal SCSLMT { get; set; }
        /// <summary>
        /// 渠道限制类型	C(1)
        /// </summary>
        public string CHNLTP { get; set; }
        /// <summary>
        /// 回单打印模式	C(1)
        /// 1默认
        /// 2打印付款回单
        /// 3打印收款回单
        /// 4不打印回单
        /// </summary>
        public string PRTMOD { get; set; }
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
        /// 补足模式       	C(1) 
        /// </summary>
        public string BTDMOD { get; set; }
        /// <summary>
        /// 额度使用优先级 	C(1)    1、子户余额优先；2、母户余额下拨
        /// </summary>
        public string AMTPRI { get; set; }
        /// <summary>
        /// 内部下拨限额标志	C(1)    	Y：限额；N：不限额
        /// </summary>
        public string IDLTAG { get; set; }
        /// <summary>
        /// 原限额协议生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ORGDAT { get; set; }
        /// <summary>
        /// 原限额协议生效日期	D, 对应<see cref="ORGDAT"/>
        /// </summary>
        [XmlElement("ORGDAT")]
        public string ORGDATStr
        {
            get
            {
                return this.ORGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ORGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 限额设置位图     	C(6)
        /// </summary>
        public string CTLMAP { get; set; }
        /// <summary>
        /// 日累计限额	F(17,2)
        /// </summary>
        public decimal? DAYMAX { get; set; }
        /// <summary>
        /// 限额一周期代码	C(1)   （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR1COD { get; set; }
        /// <summary>
        /// 限额一周期累计天数	C(4)
        /// </summary>
        public string PR1DAY { get; set; }
        /// <summary>
        /// 限额一周期起始日	D
        /// 限额设置位图第4位为N时必须为0
        /// 周期代码PR2COD为M-月时取值范围[1, 31]
        /// 周期代码PR2COD为W-周时取值范围[1, 7]
        /// 周期代码PR2COD为T-旬时必须为0。
        /// </summary>
        public string PR1STR { get; set; }
        /// <summary>
        /// 限额一周期限额	F(17,2)
        /// </summary>
        public decimal? PR1AMT { get; set; }
        /// <summary>
        /// 限额二周期代码	C(1)  （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
        /// </summary>
        public string PR2COD { get; set; }
        /// <summary>
        /// 限额二周期累计天数	C(4)
        /// </summary>
        public string PR2DAY { get; set; }
        /// <summary>
        /// 限额二周期起始日	D
        /// 限额设置位图第4位为N时必须为0
        /// 周期代码PR2COD为M-月时取值范围[1, 31]
        /// 周期代码PR2COD为W-周时取值范围[1, 7]
        /// 周期代码PR2COD为T-旬时必须为0。
        /// </summary>
        public string PR2STR { get; set; }
        /// <summary>
        /// 限额二周期限额	F(17,2)
        /// </summary>
        public decimal? PR2AMT { get; set; }
        /// <summary>
        /// 多级联动下拨层级 	C(2)
        /// </summary>
        public string FDDLEV { get; set; }
        /// <summary>
        /// 划转比例         	C(3)
        /// </summary>
        public string TRFRAT { get; set; }
        /// <summary>
        /// 暂停类型        	C(1)
        /// </summary>
        public string SSPTYP { get; set; }
        /// <summary>
        /// 协议临时暂停开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SPDSDT { get; set; }
        /// <summary>
        /// 协议临时暂停开始日期	D, 对应<see cref="SPDSDT"/>
        /// </summary>
        [XmlElement("SPDSDT")]
        public string SPDSDTStr
        {
            get
            {
                return this.SPDSDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.SPDSDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SPDSDT = tmp;
                }
            }
        }
        /// <summary>
        /// 协议临时暂停终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SPDEDT { get; set; }
        /// <summary>
        /// 协议临时暂停终止日期	D, 对应<see cref="SPDEDT"/>
        /// </summary>
        [XmlElement("SPDEDT")]
        public string SPDEDTStr
        {
            get
            {
                return this.SPDEDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.SPDEDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SPDEDT = tmp;
                }
            }
        }
        /// <summary>
        /// 备注	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 版本号	C(4)
        /// </summary>
        public string RCDVER { get; set; }
        /// <summary>
        /// 业务参考号       	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTTDUADDZ1
    {
        /// <summary>
        /// 产品编号    	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 分行号           	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号      	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 对方户口号  	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 协议转账间隔	C(1)
        /// D:日
        /// M:月
        /// S:季
        /// W:周
        /// </summary>
        public string CSTDUR { get; set; }
        /// <summary>
        /// 协议转账时点	C(30)
        /// </summary>
        public string CSTDAY { get; set; }
        /// <summary>
        /// 协议转账时间	T
        /// </summary>
        public string CSTTIM { get; set; }
        /// <summary>
        /// 期末标记   	C(1)    B:期初 N:定期 Y:期末
        /// </summary>
        public string ENDTAG { get; set; }
        /// <summary>
        /// 上划模式   	C(1)
        /// 1:留底上划  
        /// 2:定额上划  
        /// 3:按比例上划
        /// 4:划整留余
        /// </summary>
        public string BTRMOD { get; set; }
        /// <summary>
        /// 留底金额       	M
        /// </summary>
        public decimal RSVAMT { get; set; }
        /// <summary>
        /// 指定金额       	M
        /// </summary>
        public decimal APTAMT { get; set; }
        /// <summary>
        /// 划转比例       	C(3)
        /// </summary>
        public string TRFRAT { get; set; }
        /// <summary>
        /// 划拨单元       	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 余额不足是否上划	C(1)
        /// </summary>
        public string SHTMOD { get; set; }
        /// <summary>
        /// 转账触发金额   	M
        /// </summary>
        public decimal ACTAMT { get; set; }
        /// <summary>
        /// 转账次数       	C(1)
        /// </summary>
        public string TRFTIM { get; set; }
        /// <summary>
        /// 第二次转账时间 	T
        /// </summary>
        public string SECTIM { get; set; }
        /// <summary>
        /// 节假日转账模式 	C(1)
        /// </summary>
        public string TRFMOD { get; set; }
        /// <summary>
        /// 回单打印模式   	C(1)
        /// 1:默认
        /// 2:打印付款回单
        /// 3:打印收款回单
        /// 4:不打印回单
        /// </summary>
        public string PRTMOD { get; set; }
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
        /// 备注	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 业务参考号       	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTTDUMNTZ1
    {
        /// <summary>
        /// 产品编号    	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 分行号           	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号      	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 对方户口号  	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 维护类型     	C(1)
        /// A:恢复
        /// B:暂停
        /// C:维护协议要素
        /// D:终止
        /// </summary>
        public string MNTTYP { get; set; }
        /// <summary>
        /// 协议转账间隔	C(1)
        /// D:日
        /// M:月
        /// S:季
        /// W:周
        /// </summary>
        public string CSTDUR { get; set; }
        /// <summary>
        /// 协议转账时点	C(30)
        /// </summary>
        public string CSTDAY { get; set; }
        /// <summary>
        /// 协议转账时间	T
        /// </summary>
        public string CSTTIM { get; set; }
        /// <summary>
        /// 期末标记   	C(1)    B:期初 N:定期 Y:期末
        /// </summary>
        public string ENDTAG { get; set; }
        /// <summary>
        /// 上划模式   	C(1)
        /// 1:留底上划  
        /// 2:定额上划  
        /// 3:按比例上划
        /// 4:划整留余
        /// </summary>
        public string BTRMOD { get; set; }
        /// <summary>
        /// 留底金额       	M
        /// </summary>
        public decimal RSVAMT { get; set; }
        /// <summary>
        /// 指定金额       	M
        /// </summary>
        public decimal APTAMT { get; set; }
        /// <summary>
        /// 划转比例       	C(3)
        /// </summary>
        public string TRFRAT { get; set; }
        /// <summary>
        /// 划拨单元       	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 余额不足是否上划	C(1)
        /// </summary>
        public string SHTMOD { get; set; }
        /// <summary>
        /// 转账触发金额   	M
        /// </summary>
        public decimal ACTAMT { get; set; }
        /// <summary>
        /// 转账次数       	C(1)
        /// </summary>
        public string TRFTIM { get; set; }
        /// <summary>
        /// 第二次转账时间 	T
        /// </summary>
        public string SECTIM { get; set; }
        /// <summary>
        /// 节假日转账模式 	C(1)
        /// </summary>
        public string TRFMOD { get; set; }
        /// <summary>
        /// 回单打印模式   	C(1)
        /// 1:默认
        /// 2:打印付款回单
        /// 3:打印收款回单
        /// 4:不打印回单
        /// </summary>
        public string PRTMOD { get; set; }
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
        /// 业务参考号       	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CSTNBR { get; set; }
        /// <summary>
        /// 备注      Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 版本号       	C(4)
        /// </summary>
        public string RCDVER { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTTDDADDZ1
    {
        /// <summary>
        /// 产品编号    	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 分行号           	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号      	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 对方户口号  	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 协议转账间隔	C(1)
        /// D:日
        /// M:月
        /// S:季
        /// W:周
        /// </summary>
        public string CSTDUR { get; set; }
        /// <summary>
        /// 协议转账时点	C(30)
        /// </summary>
        public string CSTDAY { get; set; }
        /// <summary>
        /// 协议转账时间	T
        /// </summary>
        public string CSTTIM { get; set; }
        /// <summary>
        /// 期末标记   	C(1)    B:期初 N:定期 Y:期末
        /// </summary>
        public string ENDTAG { get; set; }
        /// <summary>
        /// 上划模式   	C(1)
        /// 1:留底上划  
        /// 2:定额上划  
        /// 3:按比例上划
        /// 4:划整留余
        /// </summary>
        public string BTRMOD { get; set; }
        /// <summary>
        /// 目标余额     	M
        /// </summary>
        public decimal APTAMT { get; set; }
        /// <summary>
        /// 划转比例       	C(3)
        /// </summary>
        public string TRFRAT { get; set; }
        /// <summary>
        /// 回单打印模式   	C(1)
        /// 1:默认
        /// 2:打印付款回单
        /// 3:打印收款回单
        /// 4:不打印回单
        /// </summary>
        public string PRTMOD { get; set; }
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
        /// 业务参考号       	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 触发金额   	M
        /// </summary>
        public decimal ACTAMT { get; set; }
        /// <summary>
        /// 节假日转账模式 	C(1)
        /// </summary>
        public string TRFMOD { get; set; }
        /// <summary>
        /// 转账次数       	C(1)
        /// </summary>
        public string TRFTIM { get; set; }
        /// <summary>
        /// 备注	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 第二次转账时间 	T
        /// </summary>
        public string SECTIM { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTTDDMNTZ1
    {
        /// <summary>
        /// 产品编号    	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 分行号           	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号      	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 对方户口号  	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 维护类型    	C(1)
        /// A:恢复
        /// B:暂停
        /// C:维护协议要素
        /// D:终止
        /// </summary>
        public string MNTTYP { get; set; }
        /// <summary>
        /// 协议转账间隔	C(1)
        /// D:日
        /// M:月
        /// S:季
        /// W:周
        /// </summary>
        public string CSTDUR { get; set; }
        /// <summary>
        /// 协议转账时点	C(30)
        /// </summary>
        public string CSTDAY { get; set; }
        /// <summary>
        /// 协议转账时间	T
        /// </summary>
        public string CSTTIM { get; set; }
        /// <summary>
        /// 期末标记   	C(1)    B:期初 N:定期 Y:期末
        /// </summary>
        public string ENDTAG { get; set; }
        /// <summary>
        /// 上划模式   	C(1)
        /// 1:留底上划  
        /// 2:定额上划  
        /// 3:按比例上划
        /// 4:划整留余
        /// </summary>
        public string BTRMOD { get; set; }
        /// <summary>
        /// 目标余额     	M
        /// </summary>
        public decimal APTAMT { get; set; }
        /// <summary>
        /// 划转比例       	C(3)
        /// </summary>
        public string TRFRAT { get; set; }
        /// <summary>
        /// 回单打印模式   	C(1)
        /// 1:默认
        /// 2:打印付款回单
        /// 3:打印收款回单
        /// 4:不打印回单
        /// </summary>
        public string PRTMOD { get; set; }
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
        /// 业务参考号       	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 触发金额   	M
        /// </summary>
        public decimal ACTAMT { get; set; }
        /// <summary>
        /// 节假日转账模式 	C(1)
        /// </summary>
        public string TRFMOD { get; set; }
        /// <summary>
        /// 转账次数       	C(1)
        /// </summary>
        public string TRFTIM { get; set; }
        /// <summary>
        /// 备注	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 版本号       	C(4)
        /// </summary>
        public string RCDVER { get; set; }
        /// <summary>
        /// 第二次转账时间 	T
        /// </summary>
        public string SECTIM { get; set; }
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CSTNBR { get; set; }
        /// <summary>
        /// 额度限制类型	C(1)
        /// 1:无限制
        /// 2:头寸余额限制
        /// 3:内部户余额限制
        /// 4:头寸户余额和内部户余额同时控制
        /// </summary>
        public string LMTTYP { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTILMADDZ1
    {
        /// <summary>
        /// 流水号        	C(10)
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 上级账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 上级账号名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 内部户编号	C(10)
        /// </summary>
        public string INANBR { get; set; }
        /// <summary>
        /// 限额设置位图	C(6)
        /// 第一位是单笔最大限额；
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
        /// 限额一周期代码	C(1) （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
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
        /// 限额二周期代码	C(1)  （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
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
        /// 限额二周期限额	F(17,2)
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
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTILMMNTZ1
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
        /// 上级账号名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 内部户编号	C(10)
        /// </summary>
        public string INANBR { get; set; }
        /// <summary>
        /// 维护类型     	C(1)
        /// </summary>
        public string MNTTYP { get; set; }
        /// <summary>
        /// 原生效日期   	D
        /// </summary>
        [XmlIgnore]
        public DateTime ORGBEG { get; set; }
        /// <summary>
        /// 原生效日期   	D, 对应<see cref="ORGBEG"/>
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
        /// 第一位是单笔最大限额；
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
        /// 限额一周期代码	C(1) （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
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
        /// 限额二周期代码	C(1)  （年-Y；月-M ； 周-W ； 旬-T； 指定时间段-S）
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
        /// 限额二周期限额	F(17,2)
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
        /// 更新记录版本号   	C(4)
        /// </summary>
        public string RCDVER { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTINAADDZ2
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号       	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 内部户名称   	Z(100)
        /// </summary>
        public string INANAM { get; set; }
        /// <summary>
        /// 初始余额     	F(17,2)
        /// </summary>
        public decimal INIBAL { get; set; }
        /// <summary>
        /// 初始余额正负 	C(1) 
        /// </summary>
        public string IBLDIR { get; set; }
        /// <summary>
        /// 内部户限额标志	C(1) 
        /// </summary>
        public string LMTTAG { get; set; }
        /// <summary>
        /// C+ 集团账户编号   	C(10)
        /// </summary>
        public string PLTNBR { get; set; }
        /// <summary>
        /// 多级现金池产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 业务参考号       	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTINADLTZ1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号       	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 内部户编号	C(10)
        /// </summary>
        public string INANBR { get; set; }
        /// <summary>
        /// 业务参考号       	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTINAMNTZ1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号       	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 内部户编号	C(10)
        /// </summary>
        public string INANBR { get; set; }
        /// <summary>
        /// 内部户名称   	Z(100)
        /// </summary>
        public string INANAM { get; set; }
        /// <summary>
        /// 初始余额     	F(17,2)
        /// </summary>
        public decimal INIBAL { get; set; }
        /// <summary>
        /// 内部户限额标志	C(1)
        /// </summary>
        public string LMTTAG { get; set; }
        /// <summary>
        /// 业务参考号       	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTOPRINTZ2
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 上级账户	C(35)
        /// </summary>
        public string TOPEAC { get; set; }
        /// <summary>
        /// 上级账号名称	Z(200)
        /// </summary>
        public string TOPNAM { get; set; }
        /// <summary>
        /// 下级账户	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级账号名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 结息开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 结息开始日期	D, 对应<see cref="BEGDAT"/>
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
        /// 结息结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结息结束日期	D, 对应<see cref="ENDDAT"/>
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
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 利息	F(17,2)
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 上存计息积数	F(17,2)
        /// </summary>
        public decimal IN1BAL { get; set; }
        /// <summary>
        /// 上存利率	F(11,7)
        /// </summary>
        public decimal IN1RAT { get; set; }
        /// <summary>
        /// 下借计息积数	F(17,2)
        /// </summary>
        public decimal IN2BAL { get; set; }
        /// <summary>
        /// 下借利率   	F(11,7)
        /// </summary>
        public decimal IN2RAT { get; set; }
        /// <summary>
        /// 分段标志   	C(1)
        /// </summary>
        public string SUBFLG { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTMTLRLTZ2
    {
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 上级账号分行号	C(2)
        /// </summary>
        public string TOPBBK { get; set; }
        /// <summary>
        /// 上级账户	C(35)
        /// </summary>
        public string TOPEAC { get; set; }
        /// <summary>
        /// 上级账号名称	Z(200)
        /// </summary>
        public string TOPNAM { get; set; }
        /// <summary>
        /// 下级账号分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级账户	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级账号名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 内部户	C(10)
        /// </summary>
        public string INNACC { get; set; }
        /// <summary>
        /// 内部户名称	Z(100)
        /// </summary>
        public string INANAM { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 母回单类型     	C(1)
        /// </summary>
        public string MUMPRT { get; set; }
        /// <summary>
        /// 母回单汇总方式 	C(1)
        /// </summary>
        public string MUMPRF { get; set; }
        /// <summary>
        /// 子回单类型     	C(1)
        /// </summary>
        public string SONPRT { get; set; }
        /// <summary>
        /// 子回单汇总方式 	C(1)
        /// </summary>
        public string SONPRF { get; set; }
        /// <summary>
        /// 初始头寸余额   	F(17,2)
        /// </summary>
        public decimal INIBAL { get; set; }
        /// <summary>
        /// 初始头寸余额正负	C(1)
        /// </summary>
        public string IBLDIR { get; set; }
        /// <summary>
        /// 计价标志       	C(1)
        /// </summary>
        public string INTFLG { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTMITADDX1
    {
        /// <summary>
        /// 分段标志         	C(1)
        /// </summary>
        public string SUBFLG { get; set; }
        /// <summary>
        /// 上存头寸计价模式 	C(1)
        /// </summary>
        public string UITMOD { get; set; }
        /// <summary>
        /// 上存头寸计价利率 	F(11,7)
        /// </summary>
        public decimal UITVAL { get; set; }
        /// <summary>
        /// 下借头寸计价模式 	C(1)
        /// </summary>
        public string DITMOD { get; set; }
        /// <summary>
        /// 下借头寸计价利率 	F(11,7)
        /// </summary>
        public decimal DITVAL { get; set; }
        /// <summary>
        /// 计价生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTBEG { get; set; }
        /// <summary>
        /// 计价生效日期	D, 对应<see cref="INTBEG"/>
        /// </summary>
        [XmlElement("INTBEG")]
        public string INTBEGStr
        {
            get
            {
                return this.INTBEG.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTBEG = tmp;
                }
            }
        }
        /// <summary>
        /// 计价失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTEND { get; set; }
        /// <summary>
        /// 计价失效日期	D, 对应<see cref="INTEND"/>
        /// </summary>
        [XmlElement("INTEND")]
        public string INTENDStr
        {
            get
            {
                return this.INTEND.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTEND = tmp;
                }
            }
        }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTMTLRLDZ1
    {
        /// <summary>
        /// 业务模式   	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 产品编号   	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 分行号     	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级账号   	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级账号名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 对方参考号 	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTMTLRLCZ1
    {
        /// <summary>
        /// 业务模式   	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 产品编号   	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 分行号     	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 母回单类型	C(1)
        /// </summary>
        public string MUMPRT { get; set; }
        /// <summary>
        /// 母回单汇总方式	C(1)
        /// </summary>
        public string MUMPRF { get; set; }
        /// <summary>
        /// 子回单类型	C(1)
        /// </summary>
        public string SONPRT { get; set; }
        /// <summary>
        /// 子回单汇总方式	C(1)
        /// </summary>
        public string SONPRF { get; set; }
        /// <summary>
        /// 对方参考号 	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 保留字段 50  	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
        /// <summary>
        /// 头寸余额     	F(17,2)
        /// </summary>
        public decimal NMLBAL { get; set; }
        /// <summary>
        /// 头寸余额正负 	C(1)
        /// </summary>
        public string NBLDIR { get; set; }
        /// <summary>
        /// 计价标志     	C(1)
        /// </summary>
        public string INTFLG { get; set; }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTMITMNTX1
    {
        /// <summary>
        /// 分段标志         	C(1)
        /// </summary>
        public string SUBFLG { get; set; }
        /// <summary>
        /// 上存头寸计价模式 	C(1)
        /// </summary>
        public string UITMOD { get; set; }
        /// <summary>
        /// 上存头寸计价利率 	F(11,7)
        /// </summary>
        public decimal UITVAL { get; set; }
        /// <summary>
        /// 下借头寸计价模式 	C(1)
        /// </summary>
        public string DITMOD { get; set; }
        /// <summary>
        /// 下借头寸计价利率 	F(11,7)
        /// </summary>
        public decimal DITVAL { get; set; }
        /// <summary>
        /// 计价生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTBEG { get; set; }
        /// <summary>
        /// 计价生效日期	D, 对应<see cref="INTBEG"/>
        /// </summary>
        [XmlElement("INTBEG")]
        public string INTBEGStr
        {
            get
            {
                return this.INTBEG.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTBEG = tmp;
                }
            }
        }
        /// <summary>
        /// 计价失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTEND { get; set; }
        /// <summary>
        /// 计价失效日期	D, 对应<see cref="INTEND"/>
        /// </summary>
        [XmlElement("INTEND")]
        public string INTENDStr
        {
            get
            {
                return this.INTEND.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTEND = tmp;
                }
            }
        }
    }
    /// <summary>
    /// 27.15.多级现金池设置详情查询响应内容
    /// </summary>
    public class NTMTLINFZ1
    {
        /// <summary>
        /// 结果描述	Z(92)
        /// </summary>
        public string RTNNAR { get; set; }
    }
}
