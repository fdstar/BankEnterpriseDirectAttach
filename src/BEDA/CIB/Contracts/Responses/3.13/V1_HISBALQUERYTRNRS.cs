using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.13.3历史余额查询响应主体
    /// </summary>
    public class V1_HISBALQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.13.3历史余额查询响应主体
        /// </summary>
        public HISBALQUERYTRNRS HISBALQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.13.3历史余额查询响应主体
    /// </summary>
    public class HISBALQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 如果客户端发送COOKIE，同步的历史记录不包括原有的CLTCOOKIE	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 交易响应
        /// </summary>
        [XmlElement(Order = 3)]
        public HISBALQUERYRS HISBALQUERYRS { get; set; }
    }
    /// <summary>
    /// 3.13.3历史余额查询响应内容
    /// </summary>
    public class HISBALQUERYRS
    {
        /// <summary>
        /// 历史余额查询请求明细
        /// </summary>
        [XmlElement(Order = 1)]
        public HISBALQUERYINFORS HISBALQUERYINFO { get; set; }
    }
    /// <summary>
    /// 历史余额查询请求明细
    /// </summary>
    public class HISBALQUERYINFORS : Requests.HISBALQUERYINFO
    {
        /// <summary>
        /// 流水细节信息	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public HISBALQUERY_DETAILS DETAILS { get; set; }
    }
    /// <summary>
    /// 流水细节信息
    /// </summary>
    public class HISBALQUERY_DETAILS
    {
        /// <summary>
        /// 流水细节信息集合
        /// </summary>
        [XmlElement("DETAIL", Order = 0)]
        public List<HISBALQUERY_DETAIL> List { get; set; }
    }
    /// <summary>
    /// 流水细节信息
    /// </summary>
    public class HISBALQUERY_DETAIL
    {
        /// <summary>
        /// 账户日终余额,最长长度17，小数点后2位	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public decimal HISBALANCE { get; set; }
        /// <summary>
        /// 贷方流水总数,整数	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public int CREDITFLOWS { get; set; }
        /// <summary>
        /// 借方流水总数,整数	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public int DEBITFLOWS { get; set; }
        /// <summary>
        /// 借方总金额,最长长度17，小数点后2位	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal DEBITAMOUNT { get; set; }
        /// <summary>
        /// 贷方总金额,最长长度17，小数点后2位	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal CREDITAMOUNT { get; set; }
        /// <summary>
        /// 流水日期 格式：yyyy-MM-dd 必回
        /// </summary>
        [XmlIgnore]
        public DateTime DTFLOW { get; set; }
        /// <summary>
        /// 结束时间 格式：yyyy-MM-dd ,对应<see cref="DTFLOW"/> 必回
        /// </summary>
        [XmlElement("DTFLOW", Order = 5)]
        public string DTFLOWStr
        {
            get
            {
                return this.DTFLOW.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.DTFLOW = tmp;
                }
            }
        }
    }
}
