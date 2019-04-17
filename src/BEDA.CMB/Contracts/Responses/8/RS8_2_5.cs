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
    /// 8.2.5.定投计划详细信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_2_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNPPDT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPPDT";
        /// <summary>
        /// 8.2.5.定投计划详细信息响应内容
        /// </summary>
        public NTFNPPDTZ NTFNPPDTZ { get; set; }
    }
    /// <summary>
    /// 8.2.5.定投计划详细信息响应内容
    /// </summary>
    public class NTFNPPDTZ
    {
        /// <summary>
        /// C(24)	投资计划编号
        /// </summary>
        public string TAAAPP { get; set; }
        /// <summary>
        /// C(8)	基金代码
        /// </summary>
        public string FNDCOD { get; set; }
        /// <summary>
        /// C(2)	开户行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// C(35)	帐号
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// Z(62)	户名
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// C(2)	结算币种
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// C(4)	交易代码
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// C(1)	执行类型
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// C(1)	投资周期单位
        /// </summary>
        public string FIXUNT { get; set; }
        /// <summary>
        /// C(3)	投资周期
        /// </summary>
        public string FIXTUN { get; set; }
        /// <summary>
        /// C(8)	开始日期
        /// </summary>
        [XmlIgnore]
        public DateTime? BEGDAT { get; set; }
        /// <summary>
        /// C(8)	开始日期, 对应<see cref="BEGDAT"/>
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
        /// M	每期金／份额	
        /// </summary>
        public decimal? TRSAMT { get; set; }
        /// <summary>
        /// M	保留余额/补足活期
        /// </summary>
        public decimal? CURAMT { get; set; }
        /// <summary>
        /// M	触发金额
        /// </summary>
        public decimal? TRGAMT { get; set; }
        /// <summary>
        /// C(8)	最后修改日期
        /// </summary>
        [XmlIgnore]
        public DateTime? MNTDAT { get; set; }
        /// <summary>
        /// C(8)	最后修改日期, 对应<see cref="MNTDAT"/>
        /// </summary>
        [XmlElement("MNTDAT")]
        public string MNTDATStr
        {
            get
            {
                return this.MNTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.MNTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MNTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// Z(30)	最后修改用户
        /// </summary>
        public string MNTUSR { get; set; }
    }
}
