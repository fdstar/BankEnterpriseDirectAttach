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
    /// 3.20.2进口信用证修改响应主体
    /// </summary>
    public class V1_LCAMENDAPPLYTRNRS : IResponse
    {
        /// <summary>
        /// 3.20.2进口信用证修改响应主体
        /// </summary>
        public LCAMENDAPPLYTRNRS LCAMENDAPPLYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.20.2进口信用证修改响应主体
    /// </summary>
    public class LCAMENDAPPLYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.20.2进口信用证修改响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCAMENDAPPLYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.20.2进口信用证修改响应内容
    /// </summary>
    public class LCAMENDAPPLYTRN_RSBODY
    {
        /// <summary>
        /// 系统关联业务编号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string XTREFERENCE { get; set; }
        /// <summary>
        /// 地区机构
        /// </summary>
        [XmlElement(Order = 1)]
        public string BRANCHNO { get; set; }
        /// <summary>
        /// 信用证号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string LCREFNO { get; set; }
        /// <summary>
        /// 申请人 长度：4*35	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string APPLICANT { get; set; }
        /// <summary>
        /// 受益人 长度：4*35	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string BENEFICIARY { get; set; }
        /// <summary>
        /// 申请事项  允许中文 150*65	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string APPLYDTL { get; set; }
        /// <summary>
        /// 备注 允许中文 6*35	非必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string COMMENT { get; set; }
        /// <summary>
        /// 申请日期, yyyy-MM-dd	必回 
        /// </summary>
        [XmlIgnore]
        public DateTime APPLYDATE { get; set; }
        /// <summary>
        /// 申请日期 yyyy-MM-dd, 对应<see cref="APPLYDATE"/>	必回 
        /// </summary>
        [XmlElement("APPLYDATE", Order = 8)]
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
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
