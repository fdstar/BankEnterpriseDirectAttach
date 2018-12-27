using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA
{
    /// <summary>
    /// 请求参数,不包含任何属性或方法，只用于数据类型约定
    /// </summary>
    /// <typeparam name="T">对应的响应参数</typeparam>
    public interface IRequest<T>
        where T : IResponse
    {
    }
}
