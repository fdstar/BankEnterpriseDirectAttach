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
    /// 8.2.8.智能现金池投资计划综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_2_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYFIX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYFIX";
        /// <summary>
        /// 8.2.8.智能现金池投资计划综合查询响应集合
        /// </summary>
        [XmlElement("NTQRYFIXZ")]
        public List<NTQRYFIXZ> List { get; set; }
    }
    /// <summary>
    /// 8.2.8.智能现金池投资计划综合查询响应内容
    /// </summary>
    public class NTQRYFIXZ
    {
        /// <summary>
        /// 流程实例号 	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 操作类型   	C(3)
        /// </summary>
        public string MNTTYP { get; set; }
        /// <summary>
        /// 定投计划编号	C(16)
        /// </summary>
        public string CTRCOD { get; set; }
        /// <summary>
        /// 基金代码   	C(8)
        /// </summary>
        public string STKCOD { get; set; }
        /// <summary>
        /// 交易代码   	C(4)
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 分行号     	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 银行帐号   	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 交易金额   	M
        /// </summary>
        public decimal? TRSAMT { get; set; }
        /// <summary>
        /// 执行类型   	C(1)
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 投资周期   	C(3)
        /// </summary>
        public string FIXTUN { get; set; }
        /// <summary>
        /// 投资周期单位	C(1) 
        /// </summary>
        public string FIXUNT { get; set; }
        /// <summary>
        /// 活期留存金额	M
        /// </summary>
        public decimal? CURAMT { get; set; }
        /// <summary>
        /// 触发金额    	M
        /// </summary>
        public decimal? TRGAMT { get; set; }
        /// <summary>
        /// 计划开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? BEGDAT { get; set; }
        /// <summary>
        /// 计划开始日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.BEGDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 申请日期   	D
        /// </summary>
        [XmlIgnore]
        public DateTime? REQDAT { get; set; }
        /// <summary>
        /// 申请日期   	D, 对应<see cref="REQDAT"/>
        /// </summary>
        [XmlElement("REQDAT")]
        public string REQDATStr
        {
            get
            {
                return this.REQDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.REQDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.REQDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 申请状态   	C(3) 	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 申请结果   	C(1) 	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 业务类型   	C(6) 
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式   	C(5) 
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 期满金额    	M
        /// </summary>
        public decimal? STKCUT { get; set; }
        /// <summary>
        /// 期满方式 	C(1)
        /// </summary>
        public string TUNTYP { get; set; }
        /// <summary>
        /// 期满日期 	D
        /// </summary>
        [XmlIgnore]
        public DateTime? VALDAT { get; set; }
        /// <summary>
        /// 期满日期 	D, 对应<see cref="VALDAT"/>
        /// </summary>
        [XmlElement("VALDAT")]
        public string VALDATStr
        {
            get
            {
                return this.VALDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.VALDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VALDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 错误描述 	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
    }
}
