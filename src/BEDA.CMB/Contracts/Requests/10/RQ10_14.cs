﻿using BEDA.CMB.Contracts.Responses;
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
    /// 10.14.委托贷款历史查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_14 : CMBBase<RQINFO>, IRequest<RS10_14>
    {
        /// <summary>
        /// SDKNTALNHST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTALNHST";
        /// <summary>
        /// 10.14.委托贷款历史查询请求内容
        /// </summary>
        public NTALNHSTX NTALNHSTX { get; set; }
    }
    /// <summary>
    /// 10.14.委托贷款历史查询请求内容
    /// </summary>
    public class NTALNHSTX
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	N(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 起始日期	D   起止日期的间隔不能超过100天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BGNDAT"/>
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
        /// 结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	D, 对应<see cref="ENDDAT"/>
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
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
