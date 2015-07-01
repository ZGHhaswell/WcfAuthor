/*----------------------------------------------------------------
// Copyright (C) 2013 ZGH
// 版权所有。
//
// 文件名：ICalculator.cs
// 功能描述：
// 
// 创建时间： 7/1/2015 9:46:40 PM
//
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfContract
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        int Add(int a, int b);
    }
}
