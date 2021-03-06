﻿using AzureStorageUpload.FormatProviders;
using System;

namespace AzureStorageUpload.Extensions
{
    public static class ExtensionMethods
    {
        public static string ToFileSize(this long l)
        {
            return String.Format(new FileSizeFormatProvider(), "{0:fs}", l);
        }
    }
}
