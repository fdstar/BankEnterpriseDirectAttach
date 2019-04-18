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
    /// 8.4.9.通知记录查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// QueryNotify
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "QueryNotify";
        /// <summary>
        /// 8.4.9.通知记录查询响应集合
        /// </summary>
        [XmlElement("NTSMAQRYZ")]
        public List<NTSMAQRYZ> List { get; set; }
    }
    /// <summary>
    /// 8.4.9.通知记录查询响应内容
    /// </summary>
    public class NTSMAQRYZ
    {
        /// <summary>
        /// 通知日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INFDAT { get; set; }
        /// <summary>
        /// 通知日期	D, 对应<see cref="INFDAT"/>
        /// </summary>
        [XmlElement("INFDAT")]
        public string INFDATStr
        {
            get
            {
                return this.INFDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INFDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 通知序号	N(3,0)
        /// </summary>
        public string INFSEQ { get; set; }
        /// <summary>
        /// 到期日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日期	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 取消日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime CNLDAT { get; set; }
        /// <summary>
        /// 取消日期	D, 对应<see cref="CNLDAT"/>
        /// </summary>
        [XmlElement("CNLDAT")]
        public string CNLDATStr
        {
            get
            {
                return this.CNLDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CNLDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 约定金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 约定币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 通知状态	C(1)
        /// A: 通知有效
        /// C: 通知已取消
        /// V: 通知已冲消
        /// D: 已删除
        /// E: 已支取
        /// </summary>
        public string INFSTS { get; set; }
        /// <summary>
        /// 通知描述	Z(12)
        /// </summary>
        public string INFTXT { get; set; }
        /// <summary>
        /// 到期状态	C(1)    含义见到期描述字段
        /// </summary>
        public string INDSTS { get; set; }
        /// <summary>
        /// 到期描述	Z(12)
        /// </summary>
        public string INDTXT { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
