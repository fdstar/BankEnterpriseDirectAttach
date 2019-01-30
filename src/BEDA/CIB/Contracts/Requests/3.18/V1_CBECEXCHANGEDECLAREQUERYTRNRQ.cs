using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.18.7跨境电商结售汇还原报送查询请求主体
    /// </summary>
    public class V1_CBECEXCHANGEDECLAREQUERYTRNRQ : IRequest<V1_CBECEXCHANGEDECLAREQUERYTRNRS>
    {
        /// <summary>
        /// 3.18.7跨境电商结售汇还原报送查询请求主体
        /// </summary>
        public CBECEXCHANGEDECLAREQUERYTRNRQ CBECEXCHANGEDECLAREQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.18.7跨境电商结售汇还原报送查询请求主体
    /// </summary>
    public class CBECEXCHANGEDECLAREQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.18.7跨境电商结售汇还原报送查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECEXCHANGEDECLAREQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.18.7跨境电商结售汇还原报送查询请求内容
    /// </summary>
    public class CBECEXCHANGEDECLAREQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 开始日期（格式为：YYYY-MM-DD，不能早于90天前，与结售汇银行流水号不能同时为空） 非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? BIGIN_DATE { get; set; }
        /// <summary>
        /// 开始日期（格式为：YYYY-MM-DD，不能早于90天前，与结售汇银行流水号不能同时为空）, 对应<see cref="BIGIN_DATE"/>	非必输
        /// </summary>
        [XmlElement("BIGIN_DATE", Order = 1)]
        public string BIGIN_DATEStr
        {
            get
            {
                return this.BIGIN_DATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.BIGIN_DATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 截止日期（格式为：YYYY-MM-DD，日期不能超过当天日期，与结售汇银行流水号不能同时为空） 非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? DUE_DATE { get; set; }
        /// <summary>
        /// 截止日期（格式为：YYYY-MM-DD，日期不能超过当天日期，与结售汇银行流水号不能同时为空）, 对应<see cref="DUE_DATE"/>	非必输
        /// </summary>
        [XmlElement("DUE_DATE", Order = 2)]
        public string DUE_DATEStr
        {
            get
            {
                return this.DUE_DATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DUE_DATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 结售汇银行流水号（与报送开始日期及截止日期不能同时为空）	非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string EXCHANGEBANKLSH { get; set; }
    }
}
