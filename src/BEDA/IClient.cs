using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA
{
    /// <summary>
    /// 客户端定义
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// <see cref="RestSharp.RestClient"/>
        /// </summary>
        IRestClient RestClient { get; }
    }
}
