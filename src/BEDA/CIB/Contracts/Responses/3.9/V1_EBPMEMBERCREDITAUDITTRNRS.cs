using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.25电子商业汇票成员单位用信审批响应主体
    /// </summary>
    public class V1_EBPMEMBERCREDITAUDITTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.25电子商业汇票成员单位用信审批响应主体
        /// </summary>
        public EBPMEMBERCREDITAUDITTRNRS EBPMEMBERCREDITAUDITTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.25电子商业汇票成员单位用信审批响应主体
    /// </summary>
    public class EBPMEMBERCREDITAUDITTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.25电子商业汇票成员单位用信审批响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPMEMBERCREDITAUDITTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.25电子商业汇票成员单位用信审批响应内容
    /// </summary>
    public class EBPMEMBERCREDITAUDITTRN_RSBODY
    {
        /// <summary>
        /// 成员单位客户号	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string MEMBERCID { get; set; }
        /// <summary>
        /// 成员客户名称	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string MEMBERNAME { get; set; }
        /// <summary>
        /// 业务类型	必回
        /// 04-质押出池
        /// 05-质押转托管
        /// 08-承兑开票
        /// 11-保证金提取
        /// 12-资产业务
        /// </summary>
        [XmlElement(Order = 5)]
        public string BIZTYPE { get; set; }
        /// <summary>
        /// 申请编号	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string APPLYNO { get; set; }
        /// <summary>
        /// 成员用信申请日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime APPLYDATE { get; set; }
        /// <summary>
        /// 成员用信申请日期，格式yyyy-MM-dd ,对应<see cref="APPLYDATE"/> 必回
        /// </summary>
        [XmlElement("APPLYDATE", Order = 7)]
        public string APPLYDATEStr
        {
            get
            {
                return this.APPLYDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPLYDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 申请金额（18,2）	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal APPLYAMT { get; set; }
        /// <summary>
        /// 审批结果， 1-审批通过 2-审批不通过 必回
        /// </summary>
        [XmlElement(Order = 9)]
        public int AUDITRESULT { get; set; }
        /// <summary>
        /// 审批意见	非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string AUDITMSG { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 40)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
