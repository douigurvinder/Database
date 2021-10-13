using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Form.Client.Htpp
{
    public interface IHtppService
    {
        Task<HtppResponseWrapper<object>> Post<T>(string url, T data);
    }
}
