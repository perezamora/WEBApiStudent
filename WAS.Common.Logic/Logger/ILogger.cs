﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAS.Common.Logic.Logger
{
    public interface ILogger
    {
        #region Metodos
        void Debug(Object message);
        void Info(Object message);
        void Warn(Object message);
        void Error(Object message);
        void Fatal(Object message);
        #endregion
    }
}
