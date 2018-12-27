﻿/****************************************************************************
*Copyright (c) 2018 yswenli All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：WENLI-PC
*公司名称：yswenli
*命名空间：SAEA.MVC
*文件名： JsonResult
*版本号： V3.6.2.2
*唯一标识：340c3ef0-2e98-4f25-998f-2bb369fa2794
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/4/10 16:48:06
*描述：
*
*=====================================================================
*修改标记
*修改时间：2018/4/10 16:48:06
*修改人： yswenli
*版本号： V3.6.2.2
*描述：
*
*****************************************************************************/
using SAEA.Common;
using System.Net;
using System.Text;

namespace SAEA.MVC
{
    public class JsonResult : ActionResult
    {
        public JsonResult(object model) : this(SerializeHelper.Serialize(model))
        {

        }
        public JsonResult(string json) : this(json, Encoding.UTF8)
        {

        }

        public JsonResult(string json, HttpStatusCode status)
        {
            this.Content = json;
            this.ContentEncoding = Encoding.UTF8;
            this.ContentType = "application/json; charset=utf-8";
            this.Status = status;
        }

        public JsonResult(string json, Encoding encoding, string contentType = "application/json; charset=utf-8")
        {
            this.Content = json;
            this.ContentEncoding = encoding;
            this.ContentType = contentType;
        }
    }
}
