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
    /// 27.7.自动划拨协议详情查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCSTINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCSTINF";
        /// <summary>
        /// 27.7.自动划拨协议详情查询响应内容
        /// </summary>
        public NTFDUINFZ1 NTFDUINFZ1 { get; set; }
        /// <summary>
        /// 27.7.自动划拨协议详情查询响应内容
        /// </summary>
        public NTFDDINFZ1 NTFDDINFZ1 { get; set; }
        /// <summary>
        /// 27.7.自动划拨协议详情查询响应内容
        /// </summary>
        public NTTDDINFZ1 NTTDDINFZ1 { get; set; }
        /// <summary>
        /// 27.7.自动划拨协议详情查询响应内容
        /// </summary>
        public NTTDUINFZ1 NTTDUINFZ1 { get; set; }
    }
    /// <summary>
    /// 27.7.自动划拨协议详情查询响应内容
    /// </summary>
    public class NTFDUINFZ1
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
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 对方户口号	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 对方客户号	C(10)
        /// </summary>
        public string OBJCLT { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
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
        /// 签订日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime SUBDAT { get; set; }
        /// <summary>
        /// 签订日期	D, 对应<see cref="SUBDAT"/>
        /// </summary>
        [XmlElement("SUBDAT")]
        public string SUBDATStr
        {
            get
            {
                return this.SUBDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SUBDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 备注	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 协议状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 协议类型	C(1)    A ：实时资金归集
        /// </summary>
        public string CSTTYP { get; set; }
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
    }
    /// <summary>
    /// 27.7.自动划拨协议详情查询响应内容
    /// </summary>
    public class NTFDDINFZ1
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
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 对方户口号	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 对方客户号	C(10)
        /// </summary>
        public string OBJCLT { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
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
        /// 签订日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime SUBDAT { get; set; }
        /// <summary>
        /// 签订日期	D, 对应<see cref="SUBDAT"/>
        /// </summary>
        [XmlElement("SUBDAT")]
        public string SUBDATStr
        {
            get
            {
                return this.SUBDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SUBDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 备注	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 协议状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 协议类型	C(1)    	B ：实时资金补足
        /// </summary>
        public string CSTTYP { get; set; }
        /// <summary>
        /// 补足模式	C(1)
        /// </summary>
        public string BTDMOD { get; set; }
        /// <summary>
        /// 额度使用优先级	C(1)    1、子户余额优先；2、母户余额下拨
        /// </summary>
        public string AMTPRI { get; set; }
        /// <summary>
        /// 内部下拨限额标志	C(1)    Y：限额；N：不限额
        /// </summary>
        public string IDLTAG { get; set; }
        /// <summary>
        /// 限额设置位图	C(6)
        /// 第一位是单笔最大限额；（不使用，为N）
        /// 第二位是日累计限额
        /// 第三位是周期限额一
        /// 第四位是周期限额二
        /// </summary>
        public string CTLMAP { get; set; }
        /// <summary>
        /// 日限额	F(17,2)
        /// </summary>
        public decimal DAYMAX { get; set; }
        /// <summary>
        /// 日已用限额	F(17,2)
        /// </summary>
        public decimal DAYUSE { get; set; }
        /// <summary>
        /// 日可用限额	F(17,2)
        /// </summary>
        public decimal DAYOBL { get; set; }
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
        /// 限额设置位图第三位为Y时必输，周期代码为T-旬时，周期起始日为0.
        /// PR1COD为W或M或S时不能为0.
        /// PR1COD为M时，取值范围[1, 31]. 
        /// PR1COD为W时，取值范围[1, 7].
        /// PR1COD为S时，要为日期格式.
        /// </summary>
        public string PR1STR { get; set; }
        /// <summary>
        /// 限额一周期限额	F(17,2)
        /// </summary>
        public decimal PR1AMT { get; set; }
        /// <summary>
        /// 限额一本期已用限额	F(17,2)
        /// </summary>
        public decimal PR1PAT { get; set; }
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
        public decimal PR1OBL { get; set; }
        /// <summary>
        /// 限额二周期代码	C(1)
        /// </summary>
        public string PR2COD { get; set; }
        /// <summary>
        /// 限额二周期累计天数	C(4)
        /// </summary>
        public string PR2DAY { get; set; }
        /// <summary>
        /// 限额二周期起始日	D
        /// 限额设置位图第四位为Y时必输，周期代码为T-旬时，周期起始日为0.为N时须为0.
        /// PR2COD为W或M或S时不能为0.
        /// PR2COD为M时，取值范围[1, 31].
        /// PR2COD为W时，取值范围[1, 7].
        /// PR2COD为S时，要为日期格式.
        /// </summary>
        public string PR2STR { get; set; }
        /// <summary>
        /// 限额二周期限额	F(17,2)
        /// </summary>
        public decimal PR2AMT { get; set; }
        /// <summary>
        /// 限额二本期已用限额	F(17,2)
        /// </summary>
        public decimal PR2PAT { get; set; }
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
        public decimal PR2OBL { get; set; }
        /// <summary>
        /// 限额协议生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? LMASDT { get; set; }
        /// <summary>
        /// 限额协议生效日期	D, 对应<see cref="LMASDT"/>
        /// </summary>
        [XmlElement("LMASDT")]
        public string LMASDTStr
        {
            get
            {
                return this.LMASDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.LMASDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LMASDT = tmp;
                }
            }
        }
        /// <summary>
        /// 限额协议失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? LMAEDT { get; set; }
        /// <summary>
        /// 限额协议失效日期	D, 对应<see cref="LMAEDT"/>
        /// </summary>
        [XmlElement("LMAEDT")]
        public string LMAEDTStr
        {
            get
            {
                return this.LMAEDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.LMAEDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LMAEDT = tmp;
                }
            }
        }
        /// <summary>
        /// 多级联动下拨层级	C(2)
        /// </summary>
        public string FDDLEV { get; set; }
        /// <summary>
        /// 临时暂停开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SPDSDT { get; set; }
        /// <summary>
        /// 临时暂停开始日期	D, 对应<see cref="SPDSDT"/>
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
        /// 临时暂停终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SPDEDT { get; set; }
        /// <summary>
        /// 临时暂停终止日期	D, 对应<see cref="SPDEDT"/>
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
    }
    /// <summary>
    /// 27.7.自动划拨协议详情查询响应内容
    /// </summary>
    public class NTTDDINFZ1
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
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 对方户口号	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 对方客户号	C(10)
        /// </summary>
        public string OBJCLT { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 协议转帐间隔	C(1)    D:日 M:月 S:季 W:周
        /// </summary>
        public string CSTDUR { get; set; }
        /// <summary>
        /// 协议转帐时点	C(30)
        /// </summary>
        public string CSTDAY { get; set; }
        /// <summary>
        /// 协议转帐时间	T
        /// </summary>
        public string CSTTIM { get; set; }
        /// <summary>
        /// 期末标记	C(1)    B:期初 N:定期 Y:期末
        /// </summary>
        public string ENDTAG { get; set; }
        /// <summary>
        /// 下拨模式	C(1) 1、目标余额； 2、名义额度比例下拨； 3、按母户联机余额下拨
        /// </summary>
        public string BTDMOD { get; set; }
        /// <summary>
        /// 目标余额	M
        /// </summary>
        public decimal APTAMT { get; set; }
        /// <summary>
        /// 划转比例	C(3)
        /// </summary>
        public string TRFRAT { get; set; }
        /// <summary>
        /// 回单打印模式	C(1)
        /// 1 默认
        /// 2 打印付款回单
        /// 3 打印收款回单
        /// 4 不打印回单
        /// </summary>
        public string PRTMOD { get; set; }
        /// <summary>
        /// 协议转账产品实例号	C(10)
        /// </summary>
        public string CSTNBR { get; set; }
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
        /// 签订日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime SUBDAT { get; set; }
        /// <summary>
        /// 签订日期	D, 对应<see cref="SUBDAT"/>
        /// </summary>
        [XmlElement("SUBDAT")]
        public string SUBDATStr
        {
            get
            {
                return this.SUBDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SUBDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 备注	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 协议状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 触发金额	M
        /// </summary>
        public decimal ACTAMT { get; set; }
        /// <summary>
        /// 下次转账日期	D
        /// </summary>
        public string NXTDAT { get; set; }
        /// <summary>
        /// 下次转账时间	T
        /// </summary>
        public string NXTTIM { get; set; }
        /// <summary>
        /// 下次转账时间 由<see cref="NXTDAT"/>和<see cref="NXTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? NextTransferTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.NXTDAT, this.NXTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 节假日转账模式	C(1)
        /// 1：默认，
        /// 2；提前至上个工作日
        /// 3：延后至下个工作日，
        /// 4：跳过 
        /// 5：如常转账
        /// </summary>
        public string TRFMOD { get; set; }
        /// <summary>
        /// 转账次数	C(1)    1 一天一次  2 一天两次
        /// </summary>
        public string TRFTIM { get; set; }
        /// <summary>
        /// 第二次转账时间	T
        /// </summary>
        public string SECTIM { get; set; }
        /// <summary>
        /// 额度限制类型	C(1)
        /// 1无限制
        /// 2头寸余额限制
        /// 3内部户余额限制
        /// 4头寸户余额和内部户余额同时控制
        /// </summary>
        public string LMTTYP { get; set; }
    }
    /// <summary>
    /// 27.7.自动划拨协议详情查询响应内容
    /// </summary>
    public class NTTDUINFZ1
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
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 对方户口号	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 对方客户号	C(10)
        /// </summary>
        public string OBJCLT { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 协议转帐间隔	C(1)    D:日 M:月 S:季 W:周
        /// </summary>
        public string CSTDUR { get; set; }
        /// <summary>
        /// 协议转帐时点	C(30)
        /// </summary>
        public string CSTDAY { get; set; }
        /// <summary>
        /// 协议转帐时间	T
        /// </summary>
        public string CSTTIM { get; set; }
        /// <summary>
        /// 期末标记	C(1)    B:期初 N:定期 Y:期末
        /// </summary>
        public string ENDTAG { get; set; }
        /// <summary>
        /// 上划模式	C(1)
        /// 1:留底上划
        /// 2:定额上划
        /// 3:按比例上划
        /// 4:划整留余
        /// </summary>
        public string BTRMOD { get; set; }
        /// <summary>
        /// 留底金额	M
        /// </summary>
        public decimal RSVAMT { get; set; }
        /// <summary>
        /// 指定金额	M
        /// </summary>
        public decimal APTAMT { get; set; }
        /// <summary>
        /// 划转比例	C(3)
        /// </summary>
        public string TRFRAT { get; set; }
        /// <summary>
        /// 划拨单元	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 余额不足是否上划标	C(1)    N:否 Y:是
        /// </summary>
        public string SHTMOD { get; set; }
        /// <summary>
        /// 转账触发金额	M
        /// </summary>
        public decimal ACTAMT { get; set; }
        /// <summary>
        /// 转账次数	C(1)    1 一天一次  2 一天两次
        /// </summary>
        public string TRFTIM { get; set; }
        /// <summary>
        /// 第二次转账时间	T
        /// </summary>
        public string SECTIM { get; set; }
        /// <summary>
        /// 节假日转账模式	C(1)
        /// 1：默认，
        /// 2；提前至上个工作日
        /// 3：延后至下个工作日，
        /// 4：跳过 
        /// 5：如常转账
        /// </summary>
        public string TRFMOD { get; set; }
        /// <summary>
        /// 回单打印模式	C(1)
        /// 1 默认
        /// 2 打印付款回单
        /// 3 打印收款回单
        /// 4 不打印回单
        /// </summary>
        public string PRTMOD { get; set; }
        /// <summary>
        /// 协议转账产品实例号	C(10)
        /// </summary>
        public string CSTNBR { get; set; }
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
        /// 签订日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime SUBDAT { get; set; }
        /// <summary>
        /// 签订日期	D, 对应<see cref="SUBDAT"/>
        /// </summary>
        [XmlElement("SUBDAT")]
        public string SUBDATStr
        {
            get
            {
                return this.SUBDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SUBDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 备注	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 协议状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 协议类型	C(1)    D ：定期资金补足
        /// </summary>
        public string CSTTYP { get; set; }
        /// <summary>
        /// 下次转账日期	D
        /// </summary>
        public string NXTDAT { get; set; }
        /// <summary>
        /// 下次转账时间	T
        /// </summary>
        public string NXTTIM { get; set; }
        /// <summary>
        /// 下次转账时间 由<see cref="NXTDAT"/>和<see cref="NXTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? NextTransferTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.NXTDAT, this.NXTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
    }
}
