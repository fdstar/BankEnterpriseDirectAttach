using BEDA.Utils;
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
    /// 2.9.批量查询余额响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS2_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQADINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQADINF";
        /// <summary>
        /// 2.9.批量查询余额响应集合
        /// </summary>
        [XmlElement("NTQADINFZ")]
        public List<NTQADINFZ> List { get; set; }
    }
    /// <summary>
    /// 2.9.批量查询余额响应内容
    /// </summary>
    public class NTQADINFZ
    {
        /// <summary>
        /// 币种	C（2,2）
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 科目	C（5,5）
        /// </summary>
        public string ACCITM { get; set; }
        /// <summary>
        /// 分行号	C（2,2）
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C（35）
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 注解	Z（62）   一般为户名
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 客户关系号	C（10）
        /// </summary>
        public string RELNBR { get; set; }
        /// <summary>
        /// 上日余额	M
        /// 当INTCOD='S'时，这个字段的值显示为"头寸额度（集团支付子公司余额）"是子公司的虚拟余额
        /// </summary>
        public decimal ACCBLV { get; set; }
        /// <summary>
        /// 联机余额	M
        /// </summary>
        public decimal ONLBLV { get; set; }
        /// <summary>
        /// 冻结余额	M	
        /// </summary>
        [XmlIgnore]
        public decimal? HLDBLV { get; set; }
        /// <summary>
        /// 冻结余额	M 对应<see cref="HLDBLV"/>
        /// </summary>
        [XmlElement("HLDBLV")]
        public string HLDBLVStr
        {
            get { return this.HLDBLV?.ToString(); }
            set { this.HLDBLV = value.TryConvert<decimal>(); }
        }
        /// <summary>
        /// 可用余额	M
        /// </summary>
        [XmlIgnore]
        public decimal? AVLBLV { get; set; }
        /// <summary>
        /// 可用余额	M   对应<see cref="AVLBLV"/>
        /// </summary>
        [XmlElement("AVLBLV")]
        public string AVLBLVStr
        {
            get { return this.AVLBLV?.ToString(); }
            set { this.AVLBLV = value.TryConvert<decimal>(); }
        }
        /// <summary>
        /// 透支额度	M
        /// </summary>
        [XmlIgnore]
        public decimal? LMTOVR { get; set; }
        /// <summary>
        /// 透支额度	M   对应<see cref="LMTOVR"/>
        /// </summary>
        [XmlElement("LMTOVR")]
        public string LMTOVRStr
        {
            get { return this.LMTOVR?.ToString(); }
            set { this.LMTOVR = value.TryConvert<decimal>(); }
        }
        /// <summary>
        /// 利息码	C（1）	S=子公司虚拟余额
        /// </summary>
        public string INTCOD { get; set; }
        /// <summary>
        /// 利率	I
        /// </summary>
        [XmlIgnore]
        public decimal? INTRAT { get; set; }
        /// <summary>
        /// 利率	I   对应<see cref="INTRAT"/>
        /// </summary>
        [XmlElement("INTRAT")]
        public string INTRATStr
        {
            get { return this.INTRAT?.ToString(); }
            set { this.INTRAT = value.TryConvert<decimal>(); }
        }
        /// <summary>
        /// 开户日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPNDAT { get; set; }
        /// <summary>
        /// 开户日	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? MUTDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="MUTDAT"/>
        /// </summary>
        [XmlElement("MUTDAT")]
        public string MUTDATStr
        {
            get
            {
                return this.MUTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.MUTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MUTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 利率类型	C（3,3）	A.35利率类型码
        /// </summary>
        public string INTTYP { get; set; }
        /// <summary>
        /// 存期	Z（12）	定期时，取值： 一天, 七天, 一个月, 三个月, 六个月, 一年, 二年, 三年, 四年, 五年
        /// </summary>
        public string DPSTXT { get; set; }
        /// <summary>
        /// 状态	C（1）	A=活动，B=冻结，C=关户
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 错误码	C（7）
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误说明	Z（92）
        /// </summary>
        public string ERRTXT { get; set; }
    }
}
