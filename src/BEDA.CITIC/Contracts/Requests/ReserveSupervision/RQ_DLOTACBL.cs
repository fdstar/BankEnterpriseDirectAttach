﻿using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 备付金账户余额查询(他行)请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLOTACBL : RqBase<RS_DLOTACBL>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLOTACBL"; set { } }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<AccQryFromOther> Collection { get; set; }
    }
}
