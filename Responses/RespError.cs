﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Walle.Components.Responses
{
    public class RespListError : RespListModel
    {
        public RespListError(Exception ex)
        {
            this.Exception = ex.Message + Environment.NewLine + ex.StackTrace;
            this.Message = "error occurd when resp a list of object.";
            this.IsOk = false;
        }
        public RespListError(Exception ex, string message)
        {
            this.Exception = ex.Message + Environment.NewLine + ex.StackTrace;
            this.Message = message;
            this.IsOk = false;
        }

        public static RespListError CreateInstance(Exception ex)
        {
            return new RespListError(ex);
        }
        public static RespListError CreateInstance(Exception ex, string message)
        {
            return new RespListError(ex, message);
        }

        public string Exception { get; set; } = string.Empty;
    }

    public class RespListError<T> : RespListModel<T> where T : class, new()
    {
        public RespListError(Exception ex)
        {
            this.Exception = ex.Message + Environment.NewLine + ex.StackTrace;
            this.Message = $"error occurd when resp a list of {nameof(T)}.";
            this.IsOk = false;
        }
        public RespListError(Exception ex, string message)
        {
            this.Exception = ex.Message + Environment.NewLine + ex.StackTrace;
            this.Message = message;
            this.IsOk = false;
        }
        public string Exception { get; set; } = string.Empty;
        public static RespListError<T> CreateInstance(Exception ex)
        {
            return new RespListError<T>(ex);
        }
        public static RespListError<T> CreateInstance(Exception ex, string message)
        {
            return new RespListError<T>(ex, message);
        }
    }

    public class RespError : RespModel
    {
        public RespError(Exception ex)
        {
            this.Exception = ex.Message + Environment.NewLine + ex.StackTrace;
            this.Message = "error occurd when resp a object.";
            this.IsOk = false;
        }
        public RespError(Exception ex, string message)
        {
            this.Exception = ex.Message + Environment.NewLine + ex.StackTrace;
            this.Message = message;
            this.IsOk = false;
        }
        public string Exception { get; set; } = string.Empty;
        public static RespError CreateInstance(Exception ex)
        {
            return new RespError(ex);
        }
        public static RespError CreateInstance(Exception ex, string message)
        {
            return new RespError(ex, message);
        }
    }

    public class RespError<T> : RespModel<T> where T : class, new()
    {
        public RespError(Exception ex)
        {
            this.Exception = ex.Message + Environment.NewLine + ex.StackTrace;
            this.Message = $"error occurd when resp a {nameof(T)}.";
            this.IsOk = false;
        }
        public RespError(Exception ex, string message)
        {
            this.Exception = ex.Message + Environment.NewLine + ex.StackTrace;
            this.Message = message;
            this.IsOk = false;
        }
        public string Exception { get; set; } = string.Empty;
        public static RespError<T> CreateInstance(Exception ex)
        {
            return new RespError<T>(ex);
        }
        public static RespError<T> CreateInstance(Exception ex, string message)
        {
            return new RespError<T>(ex, message);
        }
    }
}
