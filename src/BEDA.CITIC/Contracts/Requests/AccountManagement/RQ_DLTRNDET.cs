using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 账户明细详细信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLTRNDET : RqBase<EmptyBody, RS_DLTRNDET>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLTRNDET"; set { } }
        /// <summary>
        /// 账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 交易日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime TranDate { get; set; }
        /// <summary>
        /// 交易日期char(8) 格式YYYYMMDD, 对应<see cref="TranDate"/>
        /// </summary>
        [XmlElement("tranDate")]
        public string StartDateStr
        {
            get
            {
                return this.TranDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TranDate = tmp;
                }
            }
        }
        /// <summary>
        /// 柜员交易号char(14)，由3.1.3账户明细概要信息查询的查询结果获取
        /// </summary>
        [XmlElement("tranNo")]
        public string TranNo { get; set; }
        /// <summary>
        /// 总交易流水号 char(13)，由3.1.3账户明细概要信息查询的查询结果获取
        /// </summary>
        [XmlElement("sumTranNo")]
        public string SumTranNo { get; set; }
        /// <summary>
        /// 控制标签char(1)，0：客户系统不兼容银行端新增返回字段 1：客户系统兼容银行端新增返回字段，标签可空
        /// </summary>
        [XmlElement("controlFlag")]
        public string ControlFlag { get; set; }
    }
}
