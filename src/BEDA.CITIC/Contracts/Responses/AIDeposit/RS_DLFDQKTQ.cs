﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 靠档型智能存款账户交易查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFDQKTQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<MixedTypeAIDepositTransDetail> List { get; set; }
    }
}