﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.4.6批量托收、批量子账户托收响应主体
    /// </summary>
    public class V1_FBBATCHGATHERTRNRS : IResponse
    {
        /// <summary>
        /// 3.4.6批量托收、批量子账户托收响应
        /// </summary>
        public FBBATCHGATHERTRNRS FBBATCHGATHERTRNRS { get; set; }
    }
    /// <summary>
    /// 3.4.6批量托收、批量子账户托收响应
    /// </summary>
    public class FBBATCHGATHERTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.4.6批量托收、批量子账户托收响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FBBATCHGATHERTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.4.6批量托收、批量子账户托收响应内容
    /// </summary>
    public class FBBATCHGATHERTRN_RSBODY
    {
        /// <summary>
        /// 指令处理节点
        /// </summary>
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
