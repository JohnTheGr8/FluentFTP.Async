﻿using System;
using System.Threading.Tasks;

namespace FluentFTP.Extensions.Async
{
    /// <summary>
    /// XSHA256Async
    /// </summary>
    public static class XSHA256Async
    {
        /// <summary>
        /// Gets the XSH a256 asynchronous.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="path">The path.</param>
        /// <param name="factory">The factory.</param>
        /// <param name="creationOptions">The creation options.</param>
        /// <param name="scheduler">The scheduler.</param>
        /// <returns></returns>
        public static Task<string> GetXSHA256Async(this FtpClient client, string path,
            TaskFactory<string> factory = null,
            TaskCreationOptions creationOptions = default(TaskCreationOptions),
            TaskScheduler scheduler = null)
        {
            return (factory = factory ?? Task<string>.Factory).FromAsync(
                client.BeginGetXSHA256(path, null, null),
                XSHA256.EndGetXSHA256,
                creationOptions, scheduler ?? factory.Scheduler ?? TaskScheduler.Current);
        }
    }
}
