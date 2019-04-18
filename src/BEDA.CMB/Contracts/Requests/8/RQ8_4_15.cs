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
    /// 8.4.15.网上转网下申请查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_15 : CMBBase<RQINFO>, IRequest<RS8_4_15>
    {
        /// <summary>
        /// QueryTransfer
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "QueryTransfer";
        /// <summary>
        /// 8.4.15.网上转网下申请查询请求内容
        /// </summary>
        public NTFNCAPQX NTFNCAPQX { get; set; }
    }
    /// <summary>
    /// 8.4.15.网上转网下申请查询请求内容
    /// </summary>
    public class NTFNCAPQX
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1   空表示全部
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 通知存款帐号	C(35)   定期/通知存款帐号（空表示全部）
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 开始日	D   开始日和结束日的间隔不能超过100天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 开始日	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日	D   开始日和结束日的间隔不能超过100天
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日	D, 对应<see cref="ENDDAT"/>
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
        /// 状态	C(1)     A未处理的才能作取消操作
        /// *: 全部
        /// A: 未处理
        /// C: 已处理
        /// D: 已取消
        /// </summary>
        public string STSCOD { get; set; } = "*";
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
